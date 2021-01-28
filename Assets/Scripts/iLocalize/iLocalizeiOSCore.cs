// We need this one for importing our IOS functions
#if UNITY_IOS
using System;
using System.Runtime.InteropServices;
using AOT;
using static iLocalizeDefine;

public class iLocalizeiOSCore : IiLocalizeCore
{

    static event OnTranslationPreparedCallback _iOSInitCallback;


    [DllImport("__Internal")]
    private static extern void unity_initBuild(string appKey, string language, bool isInternationalizing, bool isBuildDebug);

    public delegate void iOSOnTranslationPrepared(bool isSuccess);
    [MonoPInvokeCallback(typeof(iOSOnTranslationPrepared))]
    private static void iOSInitCallback(bool isSuccess)
    {
        if (_iOSInitCallback != null)
        {
            _iOSInitCallback(isSuccess);

        }
    }

    [DllImport("__Internal")]
    private static extern void unity_setOnInitializedCallback(iOSOnTranslationPrepared callBack);

    [DllImport("__Internal")]
    private static extern string unity_getStringDefault_g2g(string code, string defaultStr);

    [DllImport("__Internal")]
    private static extern void unity_updateLanguage(string language);

    [DllImport("__Internal")]
    private static extern void unity_setLogEnable(bool enable);

    [DllImport("__Internal")]
    private static extern void unity_evaluateString(string code,string stringContent);

    [DllImport("__Internal")]
    private static extern void unity_updateUserInfo_g2g(string userId, string userTags);

    [DllImport("__Internal")]
    private static extern void unity_checkStringOverflow(string pageId, string stringId, string stringRealContent, float designWidth, float designHeight,float measuredWidth, float measuredHeight, string fontFamily, float fontSize, float lineSpacing, int textAlign, bool isBold, bool isItalic, bool isMultipleLine);

    [DllImport("__Internal")]
    private static extern void unity_enableEvaluateFunction(bool isOpen);



    public void Init(string appKey, string language, bool isInternationalizing, bool isBuildDebug)
    {
        unity_initBuild(appKey, language, isInternationalizing, isBuildDebug);
    }

    public void Init(string appKey, string language, bool isInternationalizing)
    {
        unity_initBuild(appKey, language, isInternationalizing,false);
    }

    public void SetOnTranslationPreparedCallback(OnTranslationPreparedCallback callback)
    {
        _iOSInitCallback = callback;
        unity_setOnInitializedCallback(iOSInitCallback);
    }

    public string GetString(string code, string defaultStr)
    {
        Console.WriteLine("---------> unity_getStringDefault:");
        return unity_getStringDefault_g2g(code, defaultStr);
    }
    public string GetString(string code)
    {
        Console.WriteLine("---------> GetString:");
        return GetString(code, "");
    }

    public void UpdateLanguage(string language)
    {
        unity_updateLanguage(language);
    }

    public void SetLogEnable(bool enable)
    {
        unity_setLogEnable(enable);
    }

    public void EvaluateString(string code, string stringContent)
    {
        unity_evaluateString(code, stringContent);
    }

    public void UpdateUserInfo(iLocalizeUserConfig userConfig)
    {
        Console.WriteLine("---------> UpdateUserInfo:");
        unity_updateUserInfo_g2g(userConfig.GetUserId(), userConfig.GetUserTags());
    }

    public void CheckStringOverflow(iLCheckOverflowConfig checkOverflowConfig)
    {
        unity_checkStringOverflow(checkOverflowConfig.GetPageId(), checkOverflowConfig.GetStringId(), checkOverflowConfig.GetStringRealContent(), checkOverflowConfig.GetDesignWidth(), checkOverflowConfig.GetDesignHeight(), checkOverflowConfig.GetMeasuredWidth(), checkOverflowConfig.GetMeasuredHeight(), checkOverflowConfig.GetFontFamily(), checkOverflowConfig.GetFontSize(), checkOverflowConfig.GetLineSpacing(), checkOverflowConfig.GetTextAlign(), checkOverflowConfig.GetIsBold(), checkOverflowConfig.GetIsItalic(), checkOverflowConfig.GetIsMultipleLine());
    }

    public void EnableEvaluateFunction(bool enable)
    {
        unity_enableEvaluateFunction(enable);
    }

}

#endif