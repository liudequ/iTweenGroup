using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;
using UnityEditor;
using UnityEngine;

public class iTweenGroupEditor : EditorWindow
{

    List<string> trueFalseOptions = new List<string>() { "True", "False" };

    Dictionary<string, object> mModifyValues;


    private iTweenGroup mTweenGroup;

    private iTweenData mViewData;

    private Vector2 mListScrollPos;

    private Vector2 mInspectorScrollPos;

    private List<iTweenData> mSelectTweenDatas = new List<iTweenData>();

    #region srot

    private bool isSort = false;

    private float mSortStartDelay = 0f;

    private float mSortInterval = 0f;

    private float mSortDuration = 0f;

    #endregion

    #region batch

    private bool isBatch = false;

    #endregion

    [MenuItem("Magiccube/iTween/GroupEditor")]
    public static void OpenWindow()
    {
        var win = EditorWindow.GetWindow<iTweenGroupEditor>();
    }


    void OnGUI()
    {
        int height = 0;
        this.mTweenGroup = EditorGUILayout.ObjectField(this.mTweenGroup, typeof(iTweenGroup), true) as iTweenGroup;
        height += 20;
        if (mTweenGroup != null)
        {
            GUILayout.BeginArea(new Rect(0, height, position.width / 2, position.height));

            this.DrawiTweenList();

            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(position.width / 2, height, position.width / 2, position.height));

            if (this.isSort)
            {
                this.DrawSortiTweens();
            }
            else if (isBatch)
            {
                this.DrawBatchiTweens();
            }
            else
            {
                this.DrawiTweenInspector();
            }


            GUILayout.EndArea();

            if (GUI.changed)
            {
                Undo.RecordObject(this.mTweenGroup, "iTweenGroup Modify");
                EditorUtility.SetDirty(this.mTweenGroup);
            }
        }


        if (Application.isPlaying)
        {
            this.mViewData = null;
        }


    }

    #region Draw

    private void DrawiTweenList()
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("添加"))
        {
            var newData = new iTweenData();
            this.mTweenGroup.iTweenList.Add(newData);
        }
        if (GUILayout.Button("排序"))
        {
            this.isBatch = false;
            this.isSort = true;
        }
//        if (GUILayout.Button("批量处理(同效果)"))
//        {
//            if (this.IsCanBatch())
//            {
//                this.isSort = false;
//                this.isBatch = true;
//            }
//            else
//            {
//                EditorUtility.DisplayDialog("iTweenGroupEditor", "必须选中最少一个动画，且多个动画间的动画类型需要相同", "OK", "Cancel");
//            }
//        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Separator();

        this.mListScrollPos = EditorGUILayout.BeginScrollView(this.mListScrollPos);
        var delIndex = -1;
        var copyIndex = -1;
        for (int i = 0; i < this.mTweenGroup.iTweenList.Count; i++)
        {
            var tweenData = this.mTweenGroup.iTweenList[i];

            var color = GUI.color;
            if (tweenData.DefaultTarget != null)
            {
                GUI.color = Color.green;
                GUILayout.Label(tweenData.DefaultTarget.name + "  " + tweenData.type);
                GUI.color = color;
            }
            GUILayout.BeginHorizontal();

            color = GUI.color;
            if (this.mViewData == tweenData || this.mSelectTweenDatas.Contains(tweenData))
            {
                GUI.color = Color.gray;
            }
            else if (tweenData.DefaultTarget == null)
            {
                GUI.color = Color.red;
            }


            if (GUILayout.Button("设置选中对象组为目标"))
            {
                tweenData.targets = Selection.gameObjects;
            }

            this.DrawTargetList(tweenData);

            if (GUILayout.Button("查看参数"))
            {
                this.CancleSortOrBatch();
                this.mViewData = tweenData;
            }
            if (GUILayout.Button("删除动画"))
            {
                delIndex = i;
            }
            if (GUILayout.Button("复制动画"))
            {
                copyIndex = i;
            }
            var select = this.mSelectTweenDatas.Contains(tweenData);
            if (GUILayout.Toggle(select, "选择"))
            {
                if (!this.mSelectTweenDatas.Contains(tweenData))
                {
                    this.mSelectTweenDatas.Add(tweenData);
                }
            }
            else
            {
                if (this.mSelectTweenDatas.Contains(tweenData))
                {
                    this.mSelectTweenDatas.Remove(tweenData);
                }
            }
            GUILayout.EndHorizontal();

            EditorGUILayout.Space();
            GUI.color = color;
        }
        if (delIndex != -1)
        {
            var tween = this.mTweenGroup.iTweenList[delIndex];
            if (this.mViewData == tween)
                this.mViewData = null;
            this.mTweenGroup.iTweenList.Remove(tween);
        }
        if (copyIndex != -1)
        {
            var newData = new iTweenData();
            this.Clone(copyIndex, newData);
            this.mTweenGroup.iTweenList.Add(newData);
        }
        EditorGUILayout.EndScrollView();

        EditorGUILayout.Separator();
        EditorGUILayout.Separator();
        EditorGUILayout.Separator();
    }

    /// <summary>
    /// 绘制动画控制的目标列表
    /// </summary>
    /// <param name="data"></param>
    private void DrawTargetList(iTweenData data)
    {
        data.isShowTargetsList = EditorGUILayout.Toggle("查看目标列表", data.isShowTargetsList);

        if (data.isShowTargetsList && data.targets!=null && data.targets.Length>0)
        {
            EditorGUILayout.BeginVertical();
            for (int index = 0; index < data.targets.Length; index++)
            {
                EditorGUILayout.ObjectField(data.targets[index], typeof(GameObject));
            }
            EditorGUILayout.EndVertical();
        }
    }

    private void DrawiTweenInspector()
    {
        if (this.mViewData != null)
        {
            DrawDataInspector(this.mViewData);
            this.mViewData.Values = mModifyValues;
        }
    }


    private void DrawBatchiTweens()
    {

        this.DrawSelectList();

        var isApply = false;
        if (GUILayout.Button("应用"))
        {
            isApply = true;
        }

        this.DrawDataInspector(this.mSelectTweenDatas[0]);

        if (isApply)
        {
            for (int i = 0; i < mSelectTweenDatas.Count; i++)
            {
                var select = mSelectTweenDatas[i];
                this.CloneWithOutTime(this.mModifyValues, select);
            }
        }
    }


    private void DrawSortiTweens()
    {
        this.mInspectorScrollPos = GUILayout.BeginScrollView(this.mInspectorScrollPos);

        this.DrawSelectList();

        this.mSortStartDelay = EditorGUILayout.FloatField("开始延时", this.mSortStartDelay);

        this.mSortInterval = EditorGUILayout.FloatField("每个间隔时间", this.mSortInterval);

        this.mSortDuration = EditorGUILayout.FloatField("每个持续时间", this.mSortDuration);


        if (GUILayout.Button("应用"))
        {
            for (int i = 0; i < this.mSelectTweenDatas.Count; i++)
            {
                var tweenData = this.mSelectTweenDatas[i];
                var values = tweenData.Values;
                if (!values.ContainsKey("delay"))
                    values.Add("delay", 0);
                values["delay"] = this.mSortStartDelay + (this.mSortInterval * i);

                if (EventParamMappings.mappings[tweenData.type].ContainsKey("time"))
                {
                    if (!values.ContainsKey("time"))
                        values.Add("time", 0);
                    values["time"] = this.mSortDuration;
                }

                tweenData.Values = values;
            }
        }
        GUILayout.EndScrollView();
    }


    /// <summary>
    /// 右侧绘制选中的动画列表
    /// </summary>
    private void DrawSelectList()
    {
        int delIndex = -1;
        for (int index = 0; index < this.mSelectTweenDatas.Count; index++)
        {
            GUILayout.BeginHorizontal();
            iTweenData data = this.mSelectTweenDatas[index];
            GUILayout.Label(data.DefaultTarget.name + "  " + data.type);

            if (GUILayout.Button("删除"))
            {
                delIndex = index;
            }
            GUILayout.EndHorizontal();
        }

        if (delIndex != -1)
        {
            this.mSelectTweenDatas.RemoveAt(delIndex);
        }

        EditorGUILayout.Separator();
    }

    private void DrawDataInspector(iTweenData data)
    {

        this.mInspectorScrollPos = GUILayout.BeginScrollView(this.mInspectorScrollPos);

        var evt = data;
        if (data.type == iTweenData.TweenType.MoveTo)
        {
            if (!data.Values.ContainsKey("islocal"))
            {
                data.Values["islocal"] = true;
            }
        }
        mModifyValues = evt.Values;
        var keys = mModifyValues.Keys.ToArray();

        foreach (var key in keys)
        {
            if (typeof(Vector3OrTransform) == EventParamMappings.mappings[evt.type][key])
            {
                var val = new Vector3OrTransform();

                if (null == mModifyValues[key] || typeof(Transform) == mModifyValues[key].GetType())
                {
                    if (null == mModifyValues[key])
                    {
                        val.transform = null;
                    }
                    else
                    {
                        val.transform = (Transform)mModifyValues[key];
                    }
                    val.selected = Vector3OrTransform.transformSelected;
                }
                else if (typeof(Vector3) == mModifyValues[key].GetType())
                {
                    val.vector = (Vector3)mModifyValues[key];
                    val.selected = Vector3OrTransform.vector3Selected;
                }

                mModifyValues[key] = val;
            }
            if (typeof(Vector3OrTransformArray) == EventParamMappings.mappings[evt.type][key])
            {
                var val = new Vector3OrTransformArray();

                if (null == mModifyValues[key] || typeof(Transform[]) == mModifyValues[key].GetType())
                {
                    if (null == mModifyValues[key])
                    {
                        val.transformArray = null;
                    }
                    else
                    {
                        val.transformArray = (Transform[])mModifyValues[key];
                    }
                    val.selected = Vector3OrTransformArray.transformSelected;
                }
                else if (typeof(Vector3[]) == mModifyValues[key].GetType())
                {
                    val.vectorArray = (Vector3[])mModifyValues[key];
                    val.selected = Vector3OrTransformArray.vector3Selected;
                }
                else if (typeof(string) == mModifyValues[key].GetType())
                {
                    val.pathName = (string)mModifyValues[key];
                    val.selected = Vector3OrTransformArray.iTweenPathSelected;
                }

                mModifyValues[key] = val;
            }
        }


        GUILayout.BeginHorizontal();
        GUILayout.Label("Name(全是小写)");
        var name  = EditorGUILayout.TextField(evt.tweenName);
        evt.tweenName = name.ToLower();
        GUILayout.EndHorizontal();



        EditorGUILayout.Separator();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Event Type");
        var prevType = evt.type;
        evt.type = (iTweenData.TweenType)EditorGUILayout.EnumPopup(evt.type);
        if (prevType != evt.type)
        {
            evt.Values.Clear();
        }
        GUILayout.EndHorizontal();

        var properties = EventParamMappings.mappings[evt.type];

        #region custom add
        if (this.isBatch)
        {
            var newProperties = new Dictionary<string, Type>();
            foreach (KeyValuePair<string, Type> pair in properties)
            {
                if (pair.Key != "time" && pair.Key != "delay" && pair.Key != "name")
                {
                    newProperties.Add(pair.Key, pair.Value);
                }
            }
            properties = newProperties;
        }
        #endregion

        foreach (var pair in properties)
        {
            var key = pair.Key;
            GUILayout.BeginHorizontal();

            bool toggle = mModifyValues.ContainsKey(key);
            toggle = EditorGUILayout.BeginToggleGroup(key, toggle);

            if (toggle)
            {
                GUILayout.BeginVertical();

                if (typeof(string) == pair.Value)
                {
                    #region custom add

                    if (key == "oncomplete")
                    {
                        if (!mModifyValues.ContainsKey("oncomplete"))
                        {
                            mModifyValues[key] = "OniTweenGroupComplete";
                        }
                    }

                    #endregion

                    mModifyValues[key] = EditorGUILayout.TextField(mModifyValues.ContainsKey(key) ? (string)mModifyValues[key] : "");

                  
                }
                else if (typeof(float) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.FloatField(mModifyValues.ContainsKey(key) ? (float)mModifyValues[key] : 0);
                }
                else if (typeof(int) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.IntField(mModifyValues.ContainsKey(key) ? (int)mModifyValues[key] : 0);
                }
                else if (typeof(bool) == pair.Value)
                {
                    GUILayout.BeginHorizontal();
                    var currentValueString = (mModifyValues.ContainsKey(key) ? (bool)mModifyValues[key] : false).ToString();
                    currentValueString = currentValueString.Substring(0, 1).ToUpper() + currentValueString.Substring(1);
                    var index = EditorGUILayout.Popup(trueFalseOptions.IndexOf(currentValueString), trueFalseOptions.ToArray());
                    GUILayout.EndHorizontal();
                    mModifyValues[key] = bool.Parse(trueFalseOptions[index]);
                }
                else if (typeof(GameObject) == pair.Value)
                {
                    #region custom add

                    if (key == "oncompletetarget")
                    {
                        if (!mModifyValues.ContainsKey("oncompletetarget"))
                        {
                            mModifyValues[key] = this.mTweenGroup.gameObject;
                        }
                    }

                    #endregion
                    mModifyValues[key] = EditorGUILayout.ObjectField(mModifyValues.ContainsKey(key) ? (GameObject)mModifyValues[key] : null, typeof(GameObject), true);
                }
                else if (typeof(Vector3) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.Vector3Field("", mModifyValues.ContainsKey(key) ? (Vector3)mModifyValues[key] : Vector3.zero);
                }

                #region custom add

                else if (typeof(AnimationCurve) == pair.Value)
                {
                    mModifyValues[key] =
                        EditorGUILayout.CurveField(mModifyValues.ContainsKey(key)
                            ? (AnimationCurve)mModifyValues[key]
                            : new AnimationCurve());
                }
                else if (typeof(iTweenData.NumberFormat) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.EnumPopup(mModifyValues.ContainsKey(key) ? (iTweenData.NumberFormat)mModifyValues[key] : iTweenData.NumberFormat.NOPoint);
                }
                #endregion
                else if (typeof(Vector3OrTransform) == pair.Value)
                {
                    if (!mModifyValues.ContainsKey(key))
                    {
                        mModifyValues[key] = new Vector3OrTransform();
                    }
                    var val = (Vector3OrTransform)mModifyValues[key];

                    val.selected = GUILayout.SelectionGrid(val.selected, Vector3OrTransform.choices, 2);

                    GUILayout.BeginHorizontal();
                    if (Vector3OrTransform.vector3Selected == val.selected)
                    {
                        if (GUILayout.Button("SetTargetPos"))
                        {
                            val.vector = evt.DefaultTarget.transform.localPosition;
                        }
                        if (GUILayout.Button("SetTargetScale"))
                        {
                            val.vector = evt.DefaultTarget.transform.localScale;
                        }
                        if (GUILayout.Button("SetTargetAngle"))
                        {
                            val.vector = evt.DefaultTarget.transform.localEulerAngles;
                        }
                        val.vector = EditorGUILayout.Vector3Field("", val.vector);
                    }
                    else
                    {
                        val.transform = (Transform)EditorGUILayout.ObjectField(val.transform, typeof(Transform), true);
                    }
                    GUILayout.EndHorizontal();
                    mModifyValues[key] = val;
                }
                else if (typeof(Vector3OrTransformArray) == pair.Value)
                {
                    if (!mModifyValues.ContainsKey(key))
                    {
                        mModifyValues[key] = new Vector3OrTransformArray();
                    }
                    var val = (Vector3OrTransformArray)mModifyValues[key];
                    val.selected = GUILayout.SelectionGrid(val.selected, Vector3OrTransformArray.choices, Vector3OrTransformArray.choices.Length);

                    if (Vector3OrTransformArray.vector3Selected == val.selected)
                    {
                        if (null == val.vectorArray)
                        {
                            val.vectorArray = new Vector3[0];
                        }
                        var elements = val.vectorArray.Length;
                        GUILayout.BeginHorizontal();
                        GUILayout.Label("Number of points");
                        elements = EditorGUILayout.IntField(elements);
                        GUILayout.EndHorizontal();
                        if (elements != val.vectorArray.Length)
                        {
                            var resizedArray = new Vector3[elements];
                            val.vectorArray.CopyTo(resizedArray, 0);
                            val.vectorArray = resizedArray;
                        }
                        for (var i = 0; i < val.vectorArray.Length; ++i)
                        {
                            val.vectorArray[i] = EditorGUILayout.Vector3Field("", val.vectorArray[i]);
                        }
                    }
                    else if (Vector3OrTransformArray.transformSelected == val.selected)
                    {
                        if (null == val.transformArray)
                        {
                            val.transformArray = new Transform[0];
                        }
                        var elements = val.transformArray.Length;
                        GUILayout.BeginHorizontal();
                        GUILayout.Label("Number of points");
                        elements = EditorGUILayout.IntField(elements);
                        GUILayout.EndHorizontal();
                        if (elements != val.transformArray.Length)
                        {
                            var resizedArray = new Transform[elements];
                            val.transformArray.CopyTo(resizedArray, 0);
                            val.transformArray = resizedArray;
                        }
                        for (var i = 0; i < val.transformArray.Length; ++i)
                        {
                            val.transformArray[i] = (Transform)EditorGUILayout.ObjectField(val.transformArray[i], typeof(Transform), true);
                        }
                    }
                    else if (Vector3OrTransformArray.iTweenPathSelected == val.selected)
                    {
                        var index = 0;
                        var paths = (GameObject.FindObjectsOfType(typeof(iTweenPath)) as iTweenPath[]);
                        if (0 == paths.Length)
                        {
                            val.pathName = "";
                            GUILayout.Label("No paths are defined");
                        }
                        else
                        {
                            for (var i = 0; i < paths.Length; ++i)
                            {
                                if (paths[i].pathName == val.pathName)
                                {
                                    index = i;
                                }
                            }
                            index = EditorGUILayout.Popup(index, (GameObject.FindObjectsOfType(typeof(iTweenPath)) as iTweenPath[]).Select(path => path.pathName).ToArray());

                            val.pathName = paths[index].pathName;
                        }
                    }
                    mModifyValues[key] = val;
                }
                else if (typeof(iTween.LoopType) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.EnumPopup(mModifyValues.ContainsKey(key) ? (iTween.LoopType)mModifyValues[key] : iTween.LoopType.none);
                }
                else if (typeof(iTween.EaseType) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.EnumPopup(mModifyValues.ContainsKey(key) ? (iTween.EaseType)mModifyValues[key] : iTween.EaseType.linear);
                }
                else if (typeof(AudioSource) == pair.Value)
                {
                    mModifyValues[key] = (AudioSource)EditorGUILayout.ObjectField(mModifyValues.ContainsKey(key) ? (AudioSource)mModifyValues[key] : null, typeof(AudioSource), true);
                }
                else if (typeof(AudioClip) == pair.Value)
                {
                    mModifyValues[key] = (AudioClip)EditorGUILayout.ObjectField(mModifyValues.ContainsKey(key) ? (AudioClip)mModifyValues[key] : null, typeof(AudioClip), true);
                }
                else if (typeof(Color) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.ColorField(mModifyValues.ContainsKey(key) ? (Color)mModifyValues[key] : Color.white);
                }
                else if (typeof(Space) == pair.Value)
                {
                    mModifyValues[key] = EditorGUILayout.EnumPopup(mModifyValues.ContainsKey(key) ? (Space)mModifyValues[key] : Space.Self);
                }

                GUILayout.EndVertical();
            }
            else
            {
                //                propertiesEnabled[key] = false;
                mModifyValues.Remove(key);
            }

            EditorGUILayout.EndToggleGroup();
            GUILayout.EndHorizontal();
            EditorGUILayout.Separator();
        }

        keys = mModifyValues.Keys.ToArray();

        foreach (var key in keys)
        {
            if (mModifyValues[key] != null && mModifyValues[key].GetType() == typeof(Vector3OrTransform))
            {
                var val = (Vector3OrTransform)mModifyValues[key];
                if (Vector3OrTransform.vector3Selected == val.selected)
                {
                    mModifyValues[key] = val.vector;
                }
                else
                {
                    mModifyValues[key] = val.transform;
                }
            }
            else if (mModifyValues[key] != null && mModifyValues[key].GetType() == typeof(Vector3OrTransformArray))
            {
                var val = (Vector3OrTransformArray)mModifyValues[key];
                if (Vector3OrTransformArray.vector3Selected == val.selected)
                {
                    mModifyValues[key] = val.vectorArray;
                }
                else if (Vector3OrTransformArray.transformSelected == val.selected)
                {
                    mModifyValues[key] = val.transformArray;
                }
                else if (Vector3OrTransformArray.iTweenPathSelected == val.selected)
                {
                    mModifyValues[key] = val.pathName;
                }
            }
        }

        GUILayout.EndScrollView();
    }


    #endregion

    private void CancleSortOrBatch()
    {
        this.isSort = false;
        this.mSelectTweenDatas.Clear();
        this.mSortDuration = 0;
        this.mSortInterval = 0;
        this.mSortStartDelay = 0;
        this.isBatch = false;
    }

    private bool IsCanBatch()
    {
        var isCanBatch = true;
        if (this.mSelectTweenDatas.Count == 0)
        {
            isCanBatch = false;
        }
        else
        {
            var type = this.mSelectTweenDatas[0].type;
            foreach (var select in this.mSelectTweenDatas)
            {
                if (type != select.type)
                {
                    isCanBatch = false;
                    break;
                }
            }
        }
        return isCanBatch;
    }

    private void CloneWithOutTime(Dictionary<string, object> copyData, iTweenData origin)
    {
        if (copyData != null)
        {
            this.CloneWithOutTime(copyData, origin.Values);
            origin.Values = origin.Values;
        }
    }

    private void CloneWithOutTime(Dictionary<string, object> copyData, Dictionary<string, object> origin)
    {
        var addDic = new Dictionary<string, object>();
        List<string> keys = new List<string>(copyData.Keys);
        foreach (var key in keys)
        {
            if (key != "time" && key != "delay")
            {
                if (origin.ContainsKey(key))
                {
                    origin[key] = copyData[key];
                }
                else
                {
                    addDic.Add(key, copyData[key]);
                }
            }
        }

        foreach (KeyValuePair<string, object> add in addDic)
        {
            origin.Add(add.Key, add.Value);
        }
    }


    private void Clone(Dictionary<string, object> copyData, iTweenData origin)
    {
        if (copyData != null)
        {
            origin.Values = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> dataValue in copyData)
            {
                origin.Values.Add(dataValue.Key, dataValue.Value);
            }
        }
    }

    private void Clone(int copyIndex, iTweenData origin)
    {
        if (copyIndex != -1)
        {
            var copyData = this.mTweenGroup.iTweenList[copyIndex];
            origin.type = copyData.type;
            Clone(copyData.Values, origin);
            origin.Values = origin.Values;
        }
    }

}

