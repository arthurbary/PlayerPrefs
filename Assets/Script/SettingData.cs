using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingData
{
    public const string VOLUME_PREF = "volume";
    public const int VOLUME_DEFAULT = 10;
    public const string INVERSEDMOUSE_PREF = "inversedMouse";
    public const bool INVERSEDMOUSE_DEFAULT = false;
    public static int volume = VOLUME_DEFAULT;
    public static bool inversedMouse = INVERSEDMOUSE_DEFAULT;
    public static void Load()
    {
        volume = PlayerPrefs.GetInt(VOLUME_PREF, VOLUME_DEFAULT);
        inversedMouse = PlayerPrefs.GetInt(INVERSEDMOUSE_PREF, INVERSEDMOUSE_DEFAULT ? 1 : 0) == 1;
    }
    public static void BumpVolume()
    {
        volume++;
        PlayerPrefs.SetInt(VOLUME_PREF, volume);
    }
    public static void ChangeInversedMouse(bool value)
    {
        inversedMouse = value;
        PlayerPrefs.SetInt(INVERSEDMOUSE_PREF, inversedMouse ? 1 : 0);
    }
    public static void ChangeInversedMouse()
    {
        ChangeInversedMouse(!inversedMouse);
    }
}
