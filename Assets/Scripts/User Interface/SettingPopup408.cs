using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopup408 : Panel408
{
    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
    }

    public void MusicToggle()
    {
        AudioManager408.Instance.ToggleMusic();
    }
    
    public void SfxToggle()
    {
        AudioManager408.Instance.ToggleSound();
    }

    public override void OnHide()
    {
        base.OnHide();
        Time.timeScale = 1;
    }
}
