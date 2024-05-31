using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField]TMP_Text volumeText;
    [SerializeField] Toggle inversedMouseToggle;

    private void Start()
    {
        SettingData.Load();
        volumeText.text = $"Volume: {SettingData.volume}";
        inversedMouseToggle.isOn = SettingData.inversedMouse;
    }
    public void BumpVolume()
    {
        SettingData.BumpVolume();
        volumeText.text = $"Volume: {SettingData.volume}";
    }
    public void ChangeInversedMouse(bool value)
    {
        SettingData.ChangeInversedMouse(value);
    }
}


