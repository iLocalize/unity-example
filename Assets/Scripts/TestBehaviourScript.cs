using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;
using UnityEngine.UI;

public class TestBehaviourScript : MonoBehaviour
{
    private string appKey = "THIS IS YOUR APP KEY";
    private string domain = "THIS IS YOUR DOMAIN";
    private string appId = "THIS IS YOUR APP ID"; 

    private void Awake()
    {
        iLocalize.Init("THIS IS YOUR APP ID", "THIS IS YOUR TARGET LANGUAGE", true);
        iLocalize.SetOnTranslationPreparedCallback(onTranslationPrepared);
    }
    void onTranslationPrepared(bool isSuccess)
    {
        Console.Write("success");
    }

    private void Start()
    {

        Dictionary<string, Action> dic = new Dictionary<string, Action>() {
            { "Canvas/getString",getStringClick },
            { "Canvas/evaluateString",evaluateStringClick },
            { "Canvas/updateUserInfo",updateUserInfoClick },
            { "Canvas/getPageString",getPageStringClick },
            { "Canvas/setScreenshotPageId",setScreenshotPageIdClick },
            { "Canvas/showFloatingWindow",showFloatingWindowClick },
            { "Canvas/updateLanguage",updateLanguageClick },
            { "Canvas/setLogEnable",setLogEnableClick },
        };

        dic.All(keyval=> {

            GameObject robotObj = GameObject.Find(keyval.Key);

            Button robotBtn = (Button)robotObj.GetComponent<Button>();

            robotBtn.onClick.AddListener(()=> { keyval.Value(); });

            return true;
        });
    }

    void getStringClick()
    {
        iLocalize.GetString("2222");
    }

    void evaluateStringClick()
    {
        iLocalize.EvaluateString("2222");
    }

    void updateUserInfoClick()
    {
        iLocalizeUserConfig userConfig = new iLocalizeUserConfig.Builder()
        .SetUserTags("VIP1,PAY3")
        .build();
        iLocalize.UpdateUserInfo(userConfig);
    }
    void getPageStringClick()
    {
#if UNITY_ANDROID
               iLocalize.GetPageString("Your pageId", "Your text id");
#endif

    }

    void setScreenshotPageIdClick()
    {
#if UNITY_ANDROID
               iLocalize.SetScreenshotPageId("Same PageId");
#endif
    }

    void showFloatingWindowClick()
    {
#if UNITY_ANDROID
               iLocalize.ShowFloatingWindow(true);
#endif
    }

    void updateLanguageClick()
    {
        iLocalize.UpdateLanguage("en");
       
    }

    void setLogEnableClick()
    {
        iLocalize.SetLogEnable(true);
    }

    

}
