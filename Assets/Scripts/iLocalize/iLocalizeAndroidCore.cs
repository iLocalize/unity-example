using UnityEngine;
#if UNITY_ANDROID
using static iLocalizeDefine;

public class iLocalizeAndroidCore : IiLocalizeCore
{

    private AndroidJavaClass javaSupport;
	private AndroidJavaObject currentActivity;

    public iLocalizeAndroidCore(){
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        javaSupport = new AndroidJavaClass("net.ilocalize.init.iLocalize");
		currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
    }

    private class ListenerAdapter : AndroidJavaProxy {

        private readonly OnTranslationPreparedCallback preparedCallback;

        public ListenerAdapter(OnTranslationPreparedCallback callback) : base("net.ilocalize.logic.callback.OnTranslationPreparedListener") {
            this.preparedCallback = callback;
        }     

        void onDataRetrieved(bool isSuccess) {
            preparedCallback(isSuccess);
        }

    }

    public void Init(string appKey, string language, bool isInternationalizing, bool isBuildDebug)
    {
        if (javaSupport != null && currentActivity != null)
        {
            javaSupport.CallStatic("init", currentActivity, appKey, language, isInternationalizing, isBuildDebug);
        }
    }

    public void SetOnTranslationPreparedCallback(OnTranslationPreparedCallback listener)
    {
        javaSupport.CallStatic("setOnTranslationPreparedCallback", listener == null ? null : new ListenerAdapter(listener));
    }

    public string GetString(string code, string defaultStr)
    {
        return javaSupport.CallStatic<string>("getString", code, defaultStr);
    }

    public string GetPageString(string pageId, string code, string defaultStr)
    {
        return javaSupport.CallStatic<string>("getPageString", pageId, code, defaultStr);
    }

    public void UpdateLanguage(string language)
    {
        javaSupport.CallStatic("updateLanguage", language);
    }

    public void SetLogEnable(bool enable)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("setLogEnable", enable);
        }
    }

    public void EvaluateString(string code,string stringContent)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("evaluateString", code,stringContent);
        }
    }

    public void UpdateUserInfo(iLocalizeUserConfig userConfig)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("updateUserInfo", GetiLocalizeUserConfig(userConfig));
        }
    }

    public void CheckStringOverflow(iLCheckOverflowConfig checkOverflowConfig)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("checkStringOverflow", GetiLCheckOverflowConfig(checkOverflowConfig));
        }
    }

    public void SetScreenshotPageId(string pageId)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("setScreenshotPageId", pageId);
        }
    }

    public void ShowFloatingWindow(bool showAutoScreenshot)
    {
        if (javaSupport != null)
        {
            javaSupport.CallStatic("showFloatingWindow", showAutoScreenshot);
        }
    }

    private AndroidJavaObject GetiLocalizeUserConfig(iLocalizeUserConfig config)
    {
        AndroidJavaObject builder = new AndroidJavaObject("net.ilocalize.config.UserConfig$Builder");
        builder.Call<AndroidJavaObject>("setUserId", config.GetUserId());
        builder.Call<AndroidJavaObject>("setUserTags", config.GetUserTags());
        return builder.Call<AndroidJavaObject>("build");
    }

    private AndroidJavaObject GetiLCheckOverflowConfig(iLCheckOverflowConfig config)
    {
        AndroidJavaObject builder = new AndroidJavaObject("net.ilocalize.config.CheckOverflowConfig$Builder");
        builder.Call<AndroidJavaObject>("setPageId", config.GetPageId());
        builder.Call<AndroidJavaObject>("setStringId", config.GetStringId());
        builder.Call<AndroidJavaObject>("setStringRealContent", config.GetStringRealContent());
        builder.Call<AndroidJavaObject>("setDesignWidth", config.GetDesignWidth());
        builder.Call<AndroidJavaObject>("setDesignHeight", config.GetDesignHeight());
        builder.Call<AndroidJavaObject>("setMeasuredWidth", config.GetMeasuredWidth());
        builder.Call<AndroidJavaObject>("setMeasuredHeight", config.GetMeasuredHeight());
        return builder.Call<AndroidJavaObject>("build");
    }

}
#endif