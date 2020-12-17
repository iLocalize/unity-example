
public class iLocalizeDefine
{

    public delegate void OnTranslationPreparedCallback(bool isSuccess);

}

public interface IiLocalizeCore
{
    void Init(string appKey, string language, bool isInternationalizing = false, bool isBuildDebug = true);
    void SetOnTranslationPreparedCallback(iLocalizeDefine.OnTranslationPreparedCallback callback);
    string GetString(string code, string defaultStr);
    void UpdateLanguage(string language);
    void SetLogEnable(bool enable);
    void EvaluateString(string code,string stringContent);
    void UpdateUserInfo(iLocalizeUserConfig userConfig);
    void CheckStringOverflow(iLCheckOverflowConfig checkOverflowConfig);

#if UNITY_ANDROID
    string GetPageString(string pageId, string code, string defaultStr);
    void SetScreenshotPageId(string pageId);
    void ShowFloatingWindow(bool showAutoScreenshot);
#endif

}

