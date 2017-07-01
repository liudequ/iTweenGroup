//#if UNITY_EDITOR
//#define iTweenGroupTest
//#endif

using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;


/// <summary>
/// 通过iTweenGroupEditor编辑相应iTween动画。并在过程中播放相应动画
/// 需要注意是必须在UI显示的情况下调用，否则，不会触发任何效果
/// </summary>
public class iTweenGroup : MonoBehaviour
{

    public System.Collections.Generic.List<iTweenData> iTweenList = new System.Collections.Generic.List<iTweenData>();

    public delegate void iTweenGroupComplete();

    public delegate void iTweenKeyFrame(string internalName);

    public iTweenGroupComplete OnComplete;

    /// <summary>
    /// 进度条动画，走到100%时，触发
    /// </summary>
    public iTweenKeyFrame OnFullSlider;

    /// <summary>
    /// PingPongOnce动画，走到中间时，触发
    /// </summary>
    public iTweenKeyFrame OnPingPongOnceFrame;


    public void PlayAll()
    {
        for (int i = 0; i < this.iTweenList.Count; i++)
        {
            var data = this.iTweenList[i];
            this.Play(data);
        }
    }

    public void Play(iTweenData data)
    {
        var optionsHash = new Hashtable();
        foreach (var pair in data.Values)
        {
            if ("path" == pair.Key && pair.Value.GetType() == typeof(string)) optionsHash.Add(pair.Key, iTweenPath.GetPath((string)pair.Value));
            else optionsHash.Add(pair.Key, pair.Value);
        }

        // We use the internalName to have a unique identifier to stop the tween
        data.internalName = string.IsNullOrEmpty(data.tweenName) ? data.type + "-" + System.Guid.NewGuid().ToString() : data.tweenName;
        optionsHash.Add("name", data.internalName);

        for (int index = 0; index < data.targets.Length; index++)
        {
            var target = data.targets[index];
            if (!target.activeInHierarchy && data.type != iTweenData.TweenType.ActivityTo)
                continue;  // 如果目标没被激活，不触发
            #region iTween
            switch (data.type)
            {
                case iTweenData.TweenType.AudioFrom:
                    iTween.AudioFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.AudioTo:
                    iTween.AudioTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.AudioUpdate:
                    iTween.AudioUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.CameraFadeFrom:
                    iTween.CameraFadeFrom(optionsHash);
                    break;
                case iTweenData.TweenType.CameraFadeTo:
                    iTween.CameraFadeTo(optionsHash);
                    break;
                case iTweenData.TweenType.ColorFrom:
                    iTween.ColorFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.ColorTo:
                    iTween.ColorTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.ColorUpdate:
                    iTween.ColorUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.FadeFrom:
                    iTween.FadeFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.FadeTo:
                    iTween.FadeTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.FadeUpdate:
                    iTween.FadeUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.LookFrom:
                    iTween.LookFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.LookTo:
                    iTween.LookTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.LookUpdate:
                    iTween.LookUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.MoveAdd:
                    iTween.MoveAdd(target, optionsHash);
                    break;
                case iTweenData.TweenType.MoveBy:
                    iTween.MoveBy(target, optionsHash);
                    break;
                case iTweenData.TweenType.MoveFrom:
                    iTween.MoveFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.MoveTo:
                    iTween.MoveTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.MoveUpdate:
                    iTween.MoveUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.PunchPosition:
                    iTween.PunchPosition(target, optionsHash);
                    break;
                case iTweenData.TweenType.PunchRotation:
                    iTween.PunchRotation(target, optionsHash);
                    break;
                case iTweenData.TweenType.PunchScale:
                    iTween.PunchScale(target, optionsHash);
                    break;
                case iTweenData.TweenType.RotateAdd:
                    iTween.RotateAdd(target, optionsHash);
                    break;
                case iTweenData.TweenType.RotateBy:
                    iTween.RotateBy(target, optionsHash);
                    break;
                case iTweenData.TweenType.RotateFrom:
                    iTween.RotateFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.RotateTo:
                    iTween.RotateTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.RotateUpdate:
                    iTween.RotateUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.ScaleAdd:
                    iTween.ScaleAdd(target, optionsHash);
                    break;
                case iTweenData.TweenType.ScaleBy:
                    iTween.ScaleBy(target, optionsHash);
                    break;
                case iTweenData.TweenType.ScaleFrom:
                    iTween.ScaleFrom(target, optionsHash);
                    break;
                case iTweenData.TweenType.ScaleTo:
                    iTween.ScaleTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.ScaleUpdate:
                    iTween.ScaleUpdate(target, optionsHash);
                    break;
                case iTweenData.TweenType.ShakePosition:
                    iTween.ShakePosition(target, optionsHash);
                    break;
                case iTweenData.TweenType.ShakeRotation:
                    iTween.ShakeRotation(target, optionsHash);
                    break;
                case iTweenData.TweenType.ShakeScale:
                    iTween.ShakeScale(target, optionsHash);
                    break;
                case iTweenData.TweenType.Stab:
                    iTween.Stab(target, optionsHash);
                    break;
                case iTweenData.TweenType.FrameAnimation:
                    iTween.FrameAnimation(target, optionsHash);
                    break;
                case iTweenData.TweenType.ActivityTo:
                    var newOption = this.Copy(optionsHash);
                    newOption.Add("activityTarget", target);
                    iTween.ActivityTo(this.gameObject, newOption);
                    break;
                case iTweenData.TweenType.NumberTo:
                    iTween.NumberTo(target, optionsHash);
                    break;
                case iTweenData.TweenType.SliderTo:
                    iTween.SliderTo(target, optionsHash);
                    break;
                default:
                    throw new System.ArgumentException("Invalid tween type: " + data.type);
            }
            #endregion
        }
    }

    /// <summary>
    /// 动态修改某个动画内的参数
    /// </summary>
    /// <param name="internalName">需要指定唯一的名称，在编辑器内"Name"中设置</param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void ModifyHashValue(string internalName, string key, object value)
    {
        for (int i = 0; i < this.iTweenList.Count; i++)
        {
            var data = this.iTweenList[i];
            if (data.tweenName.Equals(internalName))
            {
                if (EventParamMappings.mappings.ContainsKey(data.type))
                {
                    var map = EventParamMappings.mappings[data.type];
                    var type = map[key];
                    var obj = Convert.ChangeType(value, type);
                    data.Values[key] = obj;
                }
                
                break;
            }
        }
    }
#if iTweenGroupTest
    void OnGUI()
    {
        if (GUILayout.Button("Play"))
        {
            this.ResetAllToBegining();
            this.PlayAll();
        }
        if (GUILayout.Button("Reset"))
        {
            this.ResetAllToBegining();
        }

        if (GUILayout.Button("Skip"))
        {
            this.SkipAll();
        }

        if (GUILayout.Button("TestModify"))
        {
            int value = Random.Range(1, 100);
            Debug.Log(value);
            ModifyHashValue("TestModify","to",value);
        }
    }

#endif



    public void Stop()
    {
        for (int i = 0; i < iTweenList.Count; i++)
        {
            var data = iTweenList[i];
            for (int index = 0; index < data.targets.Length; index++)
            {
                var target = data.targets[index];
                if (target != null)
                {
                    iTween.StopByName(target, data.internalName);
                }
            }
        }
    }

    public void SkipAll()
    {
        for (int i = 0; i < iTweenList.Count; i++)
        {
            var data = iTweenList[i];
            for (int j = 0; j < data.targets.Length; j++)
            {
                var target = data.targets[j];
                if (target != null)
                {
                    var tween = target.GetComponents<iTween>();
                    if (tween != null)
                    {
                        for (int index = 0; index < tween.Length; index++)
                        {
                            var iTween = tween[index];
                            if (iTween._name == data.internalName)
                                iTween.Skip();
                        }
                    }
                }
            }
        }

        var itweens = this.gameObject.GetComponents<iTween>();  //有些动画组件挂在group上。
        for (int i = 0; i < itweens.Length; i++)
        {
            var itween = itweens[i];
            itween.Skip();
        }
    }

    #region 动画回调

    public void OniTweenGroupComplete()
    {
        Debug.Log("OnComplete");
        if (this.OnComplete != null)
        {
            this.OnComplete();
            this.OnComplete = null;
        }
    }

    public void OniTweenFullSlider(string internalName)
    {
        Debug.Log("OnFullSlider" + internalName);
        if (this.OnFullSlider != null)
        {
            this.OnFullSlider(internalName);
        }
    }

    public void OniTweenPingPongOnce(string internalName)
    {
        Debug.Log("OnPingPongOnce"+internalName);
        if (this.OnPingPongOnceFrame != null)
        {
            this.OnPingPongOnceFrame(internalName);
        }
    }

    #endregion


    #region Reset


    public void ResetAllToBegining()
    {
        for (int i = 0; i < this.iTweenList.Count; i++)
        {
            var data = this.iTweenList[i];
            this.ResetToBegining(data);
        }
    }

    public void ResetToBegining(iTweenData data)
    {
        for (int index = 0; index < data.targets.Length; index++)
        {
            var target = data.targets[index];
            switch (data.type)
            {
                case iTweenData.TweenType.MoveTo:
                    this.ResetMoveTo(data, target);
                    break;
                case iTweenData.TweenType.ScaleTo:
                    this.ResetScaleTo(data, target);
                    break;
                case iTweenData.TweenType.ColorTo:
                    this.ResetColorTo(data, target);
                    break;
                case iTweenData.TweenType.FrameAnimation:
                    this.ResetFrameAnimation(data, target);
                    break;
                case iTweenData.TweenType.ActivityTo:
                    this.ResetActivityTo(data, target);
                    break;
                case iTweenData.TweenType.NumberTo:
                    this.ResetNumberTo(data, target);
                    break;
                case iTweenData.TweenType.SliderTo:
                    this.ResetSliderTo(data, target);
                    break;
            }
        }

    }

    private void ResetMoveTo(iTweenData data, GameObject target)
    {
        var isLocal = false;
        if (data.Values.ContainsKey("islocal"))
        {
            isLocal = (bool)data.Values["islocal"];
        }

        if (!data.Values.ContainsKey("from"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from key ,can't reset");
            return;
        }
        var from = (Vector3)data.Values["from"];
        if (isLocal)
            target.transform.localPosition = from;
        else
            target.transform.position = from;
    }

    private void ResetScaleTo(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from key ,can't reset");
            return;
        }
        var from = (Vector3)data.Values["from"];
        target.transform.localScale = from;
    }

    private void ResetColorTo(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from key ,can't reset");
            return;
        }
        var from = (Color)data.Values["from"];
        if (target.GetComponent<UIWidget>())
        {
            target.GetComponent<UIWidget>().color = from;
        }
    }

    private void ResetFrameAnimation(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from") || !data.Values.ContainsKey("prefix") || !data.Values.ContainsKey("atlas"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from or prefix or atlas key ,can't reset");
            return;
        }
        var from = (int)data.Values["from"];
        string prefix = (string)data.Values["prefix"];
        string atlas = (string)data.Values["atlas"];
        if (target.GetComponent<UISprite>())
        {
            if (data.Values.ContainsKey("isstartempty") && (bool)data.Values["isstartempty"])
            {
                from = int.MinValue;
            }
#if UNITY_EDITOR
            target.GetComponent<UISprite>().spriteName = prefix + Mathf.RoundToInt(from).ToString();
#else
            UISystem.UITools.FillSprite(target.GetComponent<UISprite>(), atlas + "%" + prefix + Mathf.RoundToInt(from));
#endif
        }
    }

    private void ResetActivityTo(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from") || !data.Values.ContainsKey("to"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from or to  key ,can't reset");
            return;
        }
        var from = (int)data.Values["from"];
        target.SetActive(from > 0);
    }

    private void ResetNumberTo(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from") || !data.Values.ContainsKey("to"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from or to  key ,can't reset");
            return;
        }
        var from = (float)data.Values["from"];
        var label = target.GetComponent<UILabel>();

        if (!data.Values.ContainsKey("format"))
        {
            data.Values["format"] = iTweenData.NumberFormat.NOPoint;
        }

        iTweenData.NumberFormat format = (iTweenData.NumberFormat)data.Values["format"];
        label.text = GetNumberFormat(from, format);

    }

    private void ResetSliderTo(iTweenData data, GameObject target)
    {
        if (!data.Values.ContainsKey("from") || !data.Values.ContainsKey("to"))
        {
            Debug.LogWarning(target + ":" + data.internalName + " not have from or to  key ,can't reset");
            return;
        }
        var from = (float)data.Values["from"];
        var slider = target.GetComponent<UISlider>();
        if (slider != null)
        {
            slider.value = from;
        }
        var sprite = target.GetComponent<UISprite>();
        if (sprite != null)
        {
            sprite.fillAmount = from;
        }

    }
    #endregion

    #region Util



    public static string GetNumberFormat(float value, iTweenData.NumberFormat format)
    {
        switch (format)
        {
            case iTweenData.NumberFormat.OnePoint:
                return value.ToString("#0.0");
                break;
            case iTweenData.NumberFormat.TwoPoint:
                return value.ToString("#0.00");
                break;
            case iTweenData.NumberFormat.ThreePoint:
                return value.ToString("#0.000");
                break;
            case iTweenData.NumberFormat.NormalTime:
                var val = Mathf.RoundToInt(value);
                return DateTimeUtil.SecondToStringNoDay(val, DateTimeUtil.TimeLanguage.Symbol,
                    DateTimeUtil.TimePrecision.Mutant); ; 
                break;
            default:
                return value.ToString("#0");
                break;
        }
    }


    private Hashtable Copy(Hashtable ht)
    {
        var newht = new Hashtable();
        foreach (var key in ht.Keys)
        {
            newht[key] = ht[key];
        }
        return newht;
    }
    #endregion

}
