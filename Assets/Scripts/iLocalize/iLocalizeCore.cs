using System;
using UnityEngine;
using static iLocalizeDefine;

public class iLocalizeCore{

    private IiLocalizeCore localLizeCore;
    private static iLocalizeCore sInstance;

    private iLocalizeCore() {

        #if UNITY_ANDROID
            if (Application.platform == RuntimePlatform.Android) {
                localLizeCore = new iLocalizeAndroidCore();
            }
        #endif
        
        #if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer) {
                localLizeCore = new iLocalizeiOSCore();
            }
        #endif
    }

    public static iLocalizeCore GetInstance() {
        if(sInstance == null) {
            sInstance = new iLocalizeCore();
        }
        return sInstance;
    }

    public void Init(string appKey, string language, bool isInternationalizing, bool isBuildDebug) 
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.Init(appKey, language, isInternationalizing, isBuildDebug);
    }

    public void SetOnTranslationPreparedCallback(OnTranslationPreparedCallback callback)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.SetOnTranslationPreparedCallback(callback);
    }

    public string GetString(string code, string defaultStr) 
    {
        if (!IsHelpCorePrepared()) return "";
        return localLizeCore.GetString(code, defaultStr);
    }

    public void UpdateLanguage(string language)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.UpdateLanguage(language);
    }

    public void SetLogEnable(bool enable)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.SetLogEnable(enable);
    }

    public void UpdateUserInfo(iLocalizeUserConfig userConfig)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.UpdateUserInfo(userConfig);
    }

    public void EvaluateString(string code, string stringContent)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.EvaluateString(code, stringContent);
    }

    public void CheckStringOverflow(iLCheckOverflowConfig checkOverflowConfig)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.CheckStringOverflow(checkOverflowConfig);
    }


#if UNITY_ANDROID

    public string GetPageString(string pageId, string code, string defaultStr)
    {
        if (!IsHelpCorePrepared()) return "";
        return localLizeCore.GetPageString(pageId, code, defaultStr);
    }

    public void SetScreenshotPageId(string pageId)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.SetScreenshotPageId(pageId);
    }

    public void ShowFloatingWindow(bool showAutoScreenshot)
    {
        if (!IsHelpCorePrepared()) return;
        localLizeCore.ShowFloatingWindow(showAutoScreenshot);
    }

#endif

    private bool IsHelpCorePrepared() {
        return localLizeCore != null;
    }

}

