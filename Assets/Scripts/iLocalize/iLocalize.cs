using static iLocalizeDefine;

public class iLocalize{

    public static void Init(string appKey, string language, bool isInternationalizing, bool isBuildDebug = false)
    {
        iLocalizeCore.GetInstance().Init(appKey, language, isInternationalizing, isBuildDebug);
    }

    public static void SetOnTranslationPreparedCallback(OnTranslationPreparedCallback callback)
    {
        iLocalizeCore.GetInstance().SetOnTranslationPreparedCallback(callback);
    }

    public static string GetString(string code, string defaultStr = "")
    {
        return iLocalizeCore.GetInstance().GetString(code, defaultStr);
    }

    public static void UpdateLanguage(string language)
    {
        iLocalizeCore.GetInstance().UpdateLanguage(language);
    }

    public static void SetLogEnable(bool enable)
    {
        iLocalizeCore.GetInstance().SetLogEnable(enable);
    }

    public static void UpdateUserInfo(iLocalizeUserConfig userConfig)
    {
        iLocalizeCore.GetInstance().UpdateUserInfo(userConfig);
    }

    public static void EvaluateString(string code)
    {
        iLocalizeCore.GetInstance().EvaluateString(code);
    }

    public static void CheckStringOverflow(iLCheckOverflowConfig checkOverflowConfig)
    {
        iLocalizeCore.GetInstance().CheckStringOverflow(checkOverflowConfig);
    }


#if UNITY_ANDROID

    public static string GetPageString(string pageId, string code, string defaultStr = "")
    {
        return iLocalizeCore.GetInstance().GetPageString(pageId, code, defaultStr);
    }

    public static void SetScreenshotPageId(string pageId)
    {
        iLocalizeCore.GetInstance().SetScreenshotPageId(pageId);
    }

    public static void ShowFloatingWindow(bool showAutoScreenshot)
    {
        iLocalizeCore.GetInstance().ShowFloatingWindow(showAutoScreenshot);
    }

#endif

}

