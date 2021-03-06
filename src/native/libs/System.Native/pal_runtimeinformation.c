// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#include "pal_config.h"
#include "pal_runtimeinformation.h"
#include "pal_types.h"
#include <stdio.h>
#include <string.h>
#include <sys/utsname.h>
#if defined(TARGET_ANDROID)
#include <sys/system_properties.h>
#endif

const char* SystemNative_GetUnixName()
{
    return PAL_UNIX_NAME;
}

char* SystemNative_GetUnixRelease()
{
#if defined(TARGET_ANDROID)
    // get the Android API level
    char sdk_ver_str[PROP_VALUE_MAX];
    if (__system_property_get("ro.build.version.sdk", sdk_ver_str))
    {
        return strdup(sdk_ver_str);
    }
    else
    {
        return NULL;
    }
#else
    struct utsname _utsname;
    return uname(&_utsname) != -1 ?
        strdup(_utsname.release) :
        NULL;
#endif
}

int32_t SystemNative_GetUnixVersion(char* version, int* capacity)
{
    struct utsname _utsname;
    if (uname(&_utsname) != -1)
    {
        int r = snprintf(version, (size_t)(*capacity), "%s %s %s", _utsname.sysname, _utsname.release, _utsname.version);
        if (r > *capacity)
        {
            *capacity = r + 1;
            return -1;
        }
    }

    return 0;
}

/* Returns an int representing the OS Architecture. -1 if same as process architecture. */
int32_t SystemNative_GetOSArchitecture()
{
    return -1;
}
