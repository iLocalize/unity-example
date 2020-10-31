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
    private static extern void unity_evaluateString(string code);

    [DllImport("__Internal")]
    private static extern void unity_updateUserInfo_g2g(string userTags);



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

    public void EvaluateString(string code)
    {
        unity_evaluateString(code);
    }

    public void UpdateUserInfo(iLocalizeUserConfig userConfig)
    {
        Console.WriteLine("---------> UpdateUserInfo:");
        unity_updateUserInfo_g2g(userConfig.GetUserTags());
    }

}

#endif