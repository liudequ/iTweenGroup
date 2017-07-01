// Copyright (c) 2009 David Koontz
// Please direct any bugs/comments/suggestions to david@koontzfamily.org
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using UnityEngine;

public class EventParamMappings
{

    public static Dictionary<iTweenData.TweenType, Dictionary<string, Type>> mappings = new Dictionary<iTweenData.TweenType, Dictionary<string, Type>>();

    static EventParamMappings()
    {
        #region  不常用

        #region AUDIO FROM
        mappings.Add(iTweenData.TweenType.AudioFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.AudioFrom]["audiosource"] = typeof(AudioSource);
        mappings[iTweenData.TweenType.AudioFrom]["volume"] = typeof(float);
        mappings[iTweenData.TweenType.AudioFrom]["pitch"] = typeof(float);
        mappings[iTweenData.TweenType.AudioFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.AudioFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.AudioFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.AudioFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.AudioFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region AUDIO TO
        mappings.Add(iTweenData.TweenType.AudioTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.AudioTo]["audiosource"] = typeof(AudioSource);
        mappings[iTweenData.TweenType.AudioTo]["volume"] = typeof(float);
        mappings[iTweenData.TweenType.AudioTo]["pitch"] = typeof(float);
        mappings[iTweenData.TweenType.AudioTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.AudioTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.AudioTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.AudioTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.AudioTo]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioTo]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.AudioTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.AudioTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region AUDIO UPDATE
        mappings.Add(iTweenData.TweenType.AudioUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.AudioUpdate]["audiosource"] = typeof(AudioSource);
        mappings[iTweenData.TweenType.AudioUpdate]["volume"] = typeof(float);
        mappings[iTweenData.TweenType.AudioUpdate]["pitch"] = typeof(float);
        mappings[iTweenData.TweenType.AudioUpdate]["time"] = typeof(float);
        #endregion

        #region CAMERA FADE FROM
        mappings.Add(iTweenData.TweenType.CameraFadeFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.CameraFadeFrom]["amount"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.CameraFadeFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region CAMERA FADE TO
        mappings.Add(iTweenData.TweenType.CameraFadeTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.CameraFadeTo]["amount"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.CameraFadeTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.CameraFadeTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.CameraFadeTo]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeTo]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.CameraFadeTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.CameraFadeTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region COLOR FROM
        mappings.Add(iTweenData.TweenType.ColorFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ColorFrom]["color"] = typeof(Color);
        mappings[iTweenData.TweenType.ColorFrom]["r"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["g"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["b"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["a"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["namedcolorvalue"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.ColorFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ColorFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ColorFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ColorFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ColorFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ColorFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ColorFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ColorFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region COLOR UPDATE
        mappings.Add(iTweenData.TweenType.ColorUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ColorUpdate]["color"] = typeof(Color);
        mappings[iTweenData.TweenType.ColorUpdate]["r"] = typeof(float);
        mappings[iTweenData.TweenType.ColorUpdate]["g"] = typeof(float);
        mappings[iTweenData.TweenType.ColorUpdate]["b"] = typeof(float);
        mappings[iTweenData.TweenType.ColorUpdate]["a"] = typeof(float);
        mappings[iTweenData.TweenType.ColorUpdate]["namedcolorvalue"] = typeof(string);
        mappings[iTweenData.TweenType.ColorUpdate]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.ColorUpdate]["time"] = typeof(float);
        #endregion

        #region FADE FROM
        mappings.Add(iTweenData.TweenType.FadeFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.FadeFrom]["alpha"] = typeof(float);
        mappings[iTweenData.TweenType.FadeFrom]["amount"] = typeof(float);
        mappings[iTweenData.TweenType.FadeFrom]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.FadeFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.FadeFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.FadeFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.FadeFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.FadeFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region FADE TO
        mappings.Add(iTweenData.TweenType.FadeTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.FadeTo]["alpha"] = typeof(float);
        mappings[iTweenData.TweenType.FadeTo]["amount"] = typeof(float);
        mappings[iTweenData.TweenType.FadeTo]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.FadeTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.FadeTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.FadeTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.FadeTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.FadeTo]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeTo]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FadeTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.FadeTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region FADE UPDATE
        mappings.Add(iTweenData.TweenType.FadeUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.FadeUpdate]["alpha"] = typeof(float);
        mappings[iTweenData.TweenType.FadeUpdate]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.FadeUpdate]["time"] = typeof(float);
        #endregion

        #region LOOK FROM
        mappings.Add(iTweenData.TweenType.LookFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.LookFrom]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.LookFrom]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.LookFrom]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.LookFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.LookFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.LookFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.LookFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region LOOK TO
        mappings.Add(iTweenData.TweenType.LookTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.LookTo]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.LookTo]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.LookTo]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.LookTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.LookTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.LookTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.LookTo]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookTo]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.LookTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.LookTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region LOOK UPDATE
        mappings.Add(iTweenData.TweenType.LookUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.LookUpdate]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.LookUpdate]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.LookUpdate]["time"] = typeof(float);
        #endregion

        #region MOVE ADD
        mappings.Add(iTweenData.TweenType.MoveAdd, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.MoveAdd]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.MoveAdd]["x"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["y"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["z"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveAdd]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveAdd]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.MoveAdd]["time"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.MoveAdd]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.MoveAdd]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.MoveAdd]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveAdd]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveAdd]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveAdd]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveAdd]["ignoretimescale"] = typeof(bool);
        #endregion

        #region MOVE BY
        mappings.Add(iTweenData.TweenType.MoveBy, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.MoveBy]["time"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.MoveBy]["x"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["y"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["z"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveBy]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveBy]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.MoveBy]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.MoveBy]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.MoveBy]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.MoveBy]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveBy]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveBy]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveBy]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveBy]["ignoretimescale"] = typeof(bool);
        #endregion

        #region MOVE UPDATE
        mappings.Add(iTweenData.TweenType.MoveUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.MoveUpdate]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveUpdate]["x"] = typeof(float);
        mappings[iTweenData.TweenType.MoveUpdate]["y"] = typeof(float);
        mappings[iTweenData.TweenType.MoveUpdate]["z"] = typeof(float);
        mappings[iTweenData.TweenType.MoveUpdate]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveUpdate]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveUpdate]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.MoveUpdate]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.MoveUpdate]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveUpdate]["time"] = typeof(float);
        #endregion

        #region MOVE FROM
        mappings.Add(iTweenData.TweenType.MoveFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.MoveFrom]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveFrom]["path"] = typeof(Vector3OrTransformArray);
        mappings[iTweenData.TweenType.MoveFrom]["movetopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveFrom]["x"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["y"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["z"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveFrom]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveFrom]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["lookahead"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.MoveFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.MoveFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.MoveFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SCALE ADD
        mappings.Add(iTweenData.TweenType.ScaleAdd, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ScaleAdd]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.ScaleAdd]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleAdd]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ScaleAdd]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ScaleAdd]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleAdd]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleAdd]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleAdd]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleAdd]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SCALE BY
        mappings.Add(iTweenData.TweenType.ScaleBy, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ScaleBy]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.ScaleBy]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleBy]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ScaleBy]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ScaleBy]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleBy]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleBy]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleBy]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleBy]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SCALE UPDATE
        mappings.Add(iTweenData.TweenType.ScaleUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ScaleUpdate]["scale"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.ScaleUpdate]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleUpdate]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleUpdate]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleUpdate]["time"] = typeof(float);
        #endregion

        #region SCALE FROM
        mappings.Add(iTweenData.TweenType.ScaleFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ScaleFrom]["scale"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.ScaleFrom]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ScaleFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ScaleFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region ROTATE ADD
        mappings.Add(iTweenData.TweenType.RotateAdd, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.RotateAdd]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.RotateAdd]["x"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["y"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["z"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.RotateAdd]["time"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.RotateAdd]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.RotateAdd]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.RotateAdd]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateAdd]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateAdd]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateAdd]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateAdd]["ignoretimescale"] = typeof(bool);
        #endregion

        #region ROTATE BY
        mappings.Add(iTweenData.TweenType.RotateBy, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.RotateBy]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.RotateBy]["x"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["y"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["z"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.RotateBy]["time"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.RotateBy]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.RotateBy]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.RotateBy]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateBy]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateBy]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateBy]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateBy]["ignoretimescale"] = typeof(bool);
        #endregion

        #region ROTATE UPDATE
        mappings.Add(iTweenData.TweenType.RotateUpdate, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.RotateUpdate]["rotation"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.RotateUpdate]["x"] = typeof(float);
        mappings[iTweenData.TweenType.RotateUpdate]["y"] = typeof(float);
        mappings[iTweenData.TweenType.RotateUpdate]["z"] = typeof(float);
        mappings[iTweenData.TweenType.RotateUpdate]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.RotateUpdate]["time"] = typeof(float);
        #endregion

        #region ROTATE FROM
        mappings.Add(iTweenData.TweenType.RotateFrom, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.RotateFrom]["rotation"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.RotateFrom]["x"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["y"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["z"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.RotateFrom]["time"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.RotateFrom]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.RotateFrom]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.RotateFrom]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateFrom]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateFrom]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateFrom]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateFrom]["ignoretimescale"] = typeof(bool);
        #endregion

        #region STAB
        mappings.Add(iTweenData.TweenType.Stab, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.Stab]["audioclip"] = typeof(AudioClip);
        mappings[iTweenData.TweenType.Stab]["audiosource"] = typeof(AudioSource);
        mappings[iTweenData.TweenType.Stab]["volume"] = typeof(float);
        mappings[iTweenData.TweenType.Stab]["pitch"] = typeof(float);
        mappings[iTweenData.TweenType.Stab]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.Stab]["onstart"] = typeof(string);
        mappings[iTweenData.TweenType.Stab]["onstarttarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.Stab]["onstartparams"] = typeof(string);
        mappings[iTweenData.TweenType.Stab]["onupdate"] = typeof(string);
        mappings[iTweenData.TweenType.Stab]["onupdatetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.Stab]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.Stab]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.Stab]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.Stab]["oncompleteparams"] = typeof(string);
        #endregion

        #endregion

        #region COLOR TO
        mappings.Add(iTweenData.TweenType.ColorTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ColorTo]["color"] = typeof(Color);
        mappings[iTweenData.TweenType.ColorTo]["r"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["g"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["b"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["a"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["from"] = typeof(Color);
        mappings[iTweenData.TweenType.ColorTo]["namedcolorvalue"] = typeof(string);
        mappings[iTweenData.TweenType.ColorTo]["includechildren"] = typeof(bool);
        mappings[iTweenData.TweenType.ColorTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ColorTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ColorTo]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.ColorTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ColorTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ColorTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ColorTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ColorTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ColorTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ColorTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ColorTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ColorTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ColorTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ColorTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ColorTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ColorTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ColorTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region MOVE TO
        mappings.Add(iTweenData.TweenType.MoveTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.MoveTo]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveTo]["path"] = typeof(Vector3OrTransformArray);
        mappings[iTweenData.TweenType.MoveTo]["movetopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveTo]["x"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["y"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["z"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["from"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveTo]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveTo]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.MoveTo]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["lookahead"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.MoveTo]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.MoveTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.MoveTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.MoveTo]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.MoveTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.MoveTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.MoveTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.MoveTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.MoveTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.MoveTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.MoveTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.MoveTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.MoveTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.MoveTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.MoveTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.MoveTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region PUNCH POSITION
        mappings.Add(iTweenData.TweenType.PunchPosition, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.PunchPosition]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.PunchPosition]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.PunchPosition]["x"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["y"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["z"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.PunchPosition]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.PunchPosition]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.PunchPosition]["time"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.PunchPosition]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.PunchPosition]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.PunchPosition]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchPosition]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchPosition]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchPosition]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchPosition]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchPosition]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchPosition]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchPosition]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchPosition]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.PunchPosition]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchPosition]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchPosition]["ignoretimescale"] = typeof(bool);
        #endregion

        #region PUNCH ROTATION
        mappings.Add(iTweenData.TweenType.PunchRotation, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.PunchRotation]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.PunchRotation]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.PunchRotation]["x"] = typeof(float);
        mappings[iTweenData.TweenType.PunchRotation]["y"] = typeof(float);
        mappings[iTweenData.TweenType.PunchRotation]["z"] = typeof(float);
        mappings[iTweenData.TweenType.PunchRotation]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.PunchRotation]["time"] = typeof(float);
        mappings[iTweenData.TweenType.PunchRotation]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.PunchRotation]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.PunchRotation]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.PunchRotation]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchRotation]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchRotation]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchRotation]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchRotation]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchRotation]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchRotation]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchRotation]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchRotation]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.PunchRotation]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchRotation]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchRotation]["ignoretimescale"] = typeof(bool);
        #endregion

        #region PUNCH SCALE
        mappings.Add(iTweenData.TweenType.PunchScale, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.PunchScale]["position"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.PunchScale]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.PunchScale]["x"] = typeof(float);
        mappings[iTweenData.TweenType.PunchScale]["y"] = typeof(float);
        mappings[iTweenData.TweenType.PunchScale]["z"] = typeof(float);
        mappings[iTweenData.TweenType.PunchScale]["time"] = typeof(float);
        mappings[iTweenData.TweenType.PunchScale]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.PunchScale]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.PunchScale]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.PunchScale]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchScale]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchScale]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchScale]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchScale]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchScale]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.PunchScale]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.PunchScale]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchScale]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.PunchScale]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.PunchScale]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.PunchScale]["ignoretimescale"] = typeof(bool);
        #endregion

        #region ROTATE TO
        mappings.Add(iTweenData.TweenType.RotateTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.RotateTo]["rotation"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.RotateTo]["x"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["y"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["z"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["islocal"] = typeof(bool);
        mappings[iTweenData.TweenType.RotateTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.RotateTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.RotateTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.RotateTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.RotateTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.RotateTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.RotateTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.RotateTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.RotateTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.RotateTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.RotateTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.RotateTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.RotateTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.RotateTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SCALE TO
        mappings.Add(iTweenData.TweenType.ScaleTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ScaleTo]["scale"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.ScaleTo]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["from"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.ScaleTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ScaleTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.ScaleTo]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.ScaleTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ScaleTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ScaleTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ScaleTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ScaleTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ScaleTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ScaleTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ScaleTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ScaleTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ScaleTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SHAKE POSITION
        mappings.Add(iTweenData.TweenType.ShakePosition, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ShakePosition]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.ShakePosition]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.ShakePosition]["orienttopath"] = typeof(bool);
        mappings[iTweenData.TweenType.ShakePosition]["looktarget"] = typeof(Vector3OrTransform);
        mappings[iTweenData.TweenType.ShakePosition]["looktime"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["axis"] = typeof(string);
        mappings[iTweenData.TweenType.ShakePosition]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ShakePosition]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ShakePosition]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ShakePosition]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakePosition]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakePosition]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakePosition]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakePosition]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakePosition]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakePosition]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakePosition]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakePosition]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ShakePosition]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakePosition]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakePosition]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SHAKE ROTATION
        mappings.Add(iTweenData.TweenType.ShakeRotation, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ShakeRotation]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.ShakeRotation]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeRotation]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeRotation]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeRotation]["space"] = typeof(Space);
        mappings[iTweenData.TweenType.ShakeRotation]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeRotation]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeRotation]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ShakeRotation]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeRotation]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakeRotation]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakeRotation]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeRotation]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeRotation]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakeRotation]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeRotation]["ignoretimescale"] = typeof(bool);
        #endregion

        #region SHAKE SCALE
        mappings.Add(iTweenData.TweenType.ShakeScale, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ShakeScale]["amount"] = typeof(Vector3);
        mappings[iTweenData.TweenType.ShakeScale]["x"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeScale]["y"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeScale]["z"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeScale]["time"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeScale]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ShakeScale]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ShakeScale]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeScale]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakeScale]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeScale]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeScale]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakeScale]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeScale]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ShakeScale]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ShakeScale]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeScale]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeScale]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ShakeScale]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ShakeScale]["ignoretimescale"] = typeof(bool);
        #endregion

        #region FRAME ANIMATION
        mappings.Add(iTweenData.TweenType.FrameAnimation, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.FrameAnimation]["from"] = typeof(int);
        mappings[iTweenData.TweenType.FrameAnimation]["to"] = typeof(int);
        mappings[iTweenData.TweenType.FrameAnimation]["speed"] = typeof(float);
        mappings[iTweenData.TweenType.FrameAnimation]["prefix"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["atlas"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["isstartempty"] = typeof(bool);
        mappings[iTweenData.TweenType.FrameAnimation]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.FrameAnimation]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.FrameAnimation]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.FrameAnimation]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.FrameAnimation]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FrameAnimation]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.FrameAnimation]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.FrameAnimation]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.FrameAnimation]["ignoretimescale"] = typeof(bool);
        #endregion

        #region ACTIVITY TO
        mappings.Add(iTweenData.TweenType.ActivityTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.ActivityTo]["from"] = typeof(int);
        mappings[iTweenData.TweenType.ActivityTo]["to"] = typeof(int);
        mappings[iTweenData.TweenType.ActivityTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.ActivityTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.ActivityTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.ActivityTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ActivityTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ActivityTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.ActivityTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ActivityTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.ActivityTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.ActivityTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.ActivityTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.ActivityTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.ActivityTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.ActivityTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.ActivityTo]["ignoretimescale"] = typeof(bool);
        #endregion

        #region NumberTo
        mappings.Add(iTweenData.TweenType.NumberTo, new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.NumberTo]["from"] = typeof(float);
        mappings[iTweenData.TweenType.NumberTo]["to"] = typeof(float);
        mappings[iTweenData.TweenType.NumberTo]["format"] = typeof(iTweenData.NumberFormat);
        mappings[iTweenData.TweenType.NumberTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.NumberTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.NumberTo]["looptype"] = typeof(iTween.LoopType);
        mappings[iTweenData.TweenType.NumberTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.NumberTo]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.NumberTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.NumberTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.NumberTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.NumberTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.NumberTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.NumberTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.NumberTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.NumberTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.NumberTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.NumberTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.NumberTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.NumberTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.NumberTo]["ignoretimescale"] = typeof(bool);

        #endregion

        #region Slider To

        mappings.Add(iTweenData.TweenType.SliderTo,new Dictionary<string, Type>());
        mappings[iTweenData.TweenType.SliderTo]["from"] = typeof(float);
        mappings[iTweenData.TweenType.SliderTo]["to"] = typeof(float);
        mappings[iTweenData.TweenType.SliderTo]["delay"] = typeof(float);
        mappings[iTweenData.TweenType.SliderTo]["time"] = typeof(float);
        mappings[iTweenData.TweenType.SliderTo]["looptype"] = typeof(float);
        mappings[iTweenData.TweenType.SliderTo]["easetype"] = typeof(iTween.EaseType);
        mappings[iTweenData.TweenType.SliderTo]["customease"] = typeof(AnimationCurve);
        mappings[iTweenData.TweenType.SliderTo]["onfullslider"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["onfullslidertarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.SliderTo]["onfullsliderparams"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["onpingpongonce"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["onpingpongoncetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.SliderTo]["onpingpongonceparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.SliderTo]["onstart"] = typeof(string);
        //        mappings[iTweenData.TweenType.SliderTo]["onstarttarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.SliderTo]["onstartparams"] = typeof(string);
        //        mappings[iTweenData.TweenType.SliderTo]["onupdate"] = typeof(string);
        //        mappings[iTweenData.TweenType.SliderTo]["onupdatetarget"] = typeof(GameObject);
        //        mappings[iTweenData.TweenType.SliderTo]["onupdateparams"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["oncomplete"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["oncompletetarget"] = typeof(GameObject);
        mappings[iTweenData.TweenType.SliderTo]["oncompleteparams"] = typeof(string);
        mappings[iTweenData.TweenType.SliderTo]["ignoretimescale"] = typeof(bool);
        #endregion
    }
}