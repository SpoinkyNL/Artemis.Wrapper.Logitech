﻿namespace Artemis.Plugins.Wrappers.Logitech
{
    internal enum LogitechCommand
    {
        Init = 1,
        InitWithName,
        GetSdkVersion,
        GetConfigOptionNumber,
        GetConfigOptionBool,
        GetConfigOptionColor,
        GetConfigOptionRect,
        GetConfigOptionString,
        GetConfigOptionKeyInput,
        GetConfigOptionSelect,
        GetConfigOptionRange,
        SetConfigOptionLabel,
        SetTargetDevice,
        SaveCurrentLighting,
        SetLighting,
        RestoreLighting,
        FlashLighting,
        PulseLighting,
        StopEffects,
        SetLightingFromBitmap,
        SetLightingForKeyWithScanCode,
        SetLightingForKeyWithHidCode,
        SetLightingForKeyWithQuartzCode,
        SetLightingForKeyWithKeyName,
        SaveLightingForKey,
        RestoreLightingForKey,
        ExcludeKeysFromBitmap,
        FlashSingleKey,
        PulseSingleKey,
        StopEffectsOnKey,
        SetLightingForTargetZone,
        Shutdown,
    }
}