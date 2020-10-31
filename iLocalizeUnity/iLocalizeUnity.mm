//
//  iLocalizeUnity.m
//
//  Created by iLocalize on 2020/9/29.
//  Copyright © 2020 AIHelp. All rights reserved.
//

#import "iLocalizeUnity.h"
#import <Foundation/Foundation.h>
#import <iLocalizeSDK/iLocalize.h>

#if defined(__cplusplus)
extern "C" {
#endif
    
    NSString* charToNSString (const char* string)
    {
        if (string){
            return [NSString stringWithUTF8String: string];
        }else{
            return [NSString stringWithUTF8String: ""];
        }
    }

    const char* NSStringToChar (NSString* string)
    {
        if (string){
            return string.UTF8String;
        }else{
            return @"".UTF8String;
        }
    }


    void unity_initBuild (const char* appKey, const char* language, bool isInternationalizing,  bool isBuildDebug) {
        NSString *_appKey = charToNSString(appKey);
        NSString *_language = charToNSString(language);
        [iLocalize initWithAppKey:_appKey language:_language isInternationalizing:isInternationalizing isDebug:isBuildDebug];
    }
    
    void unity_setOnInitializedCallback (GGTranslationPreparedCallback callBack) {
        [iLocalize setTranslationPreparedCallback:callBack];
    }

    const char* unity_getStringDefault_g2g(const char* code, const char* defaultStr) {
        NSString *_code = charToNSString(code);
        NSString *_defaultStr = charToNSString(defaultStr);
        NSString *valueStr = [iLocalize getStringWithCode:_code defaultString:_defaultStr];
        return strdup(NSStringToChar(valueStr));
    }

    void unity_updateLanguage(const char* language) {
        NSString *_language = charToNSString(language);
        [iLocalize updateLanguage:_language];
    }

    void unity_setLogEnable(bool enable) {
        [iLocalize setLogEnable:enable];
    }

    void unity_evaluateString(const char* code) {
        NSString *_code = charToNSString(code);
        [iLocalize evaluateStringWithCode:_code];
    }

    void unity_updateUserInfo_g2g(const char* userTags) {
        iLocalizeUserConfigBuilder *configBuilder = [[iLocalizeUserConfigBuilder alloc] init];
        NSString *_userTags = charToNSString(userTags);
        configBuilder.userTags = _userTags;
        [iLocalize setUserConfig:configBuilder.build];
    }
    
#if defined(__cplusplus)
}
#endif
