//
//  iLocalizeUnity.h
//
//  Created by iLocalize on 2020/9/29.
//  Copyright © 2020 AIHelp. All rights reserved.
//

#import <iLocalizeSDK/iLocalizeSDK.h>

#ifndef Go2GlobalUnity_h
#define Go2GlobalUnity_h

extern "C" void unity_init (const char* appKey, const char* language, bool isInternationalizing);

extern "C" void unity_initBuild (const char* appKey, const char* language, bool isInternationalizing,  bool isBuildDebug);

extern "C" void unity_setOnInitializedCallback (GGTranslationPreparedCallback callBack);

extern "C" const char* unity_getStringDefault_g2g(const char* code, const char* defaultStr);

extern "C" void unity_updateLanguage(const char* language);

extern "C" void unity_setLogEnable(bool enable);

extern "C" void unity_evaluateString(const char* code);

extern "C" void unity_updateUserInfo_g2g(const char* userTags);



#endif
