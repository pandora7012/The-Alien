using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopup408 : Panel408
{

    [SerializeField] private GameObject deniedMusic, deniedSfx; 
  


    public override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
        deniedMusic.gameObject.SetActive(PlayerPrefs.GetInt("Music", 1) == 0);

        deniedSfx.gameObject.SetActive(PlayerPrefs.GetInt("SFX", 1) == 0);
   
    }

    public void MusicToggle()
    {
        AudioManager408.Instance.PlaySound(0, 1);
        AudioManager408.Instance.ToggleMusic();
        deniedMusic.gameObject.SetActive(PlayerPrefs.GetInt("Music", 1) == 0);
    }
    
    public void SfxToggle()
    {
        AudioManager408.Instance.PlaySound(0, 1);
        AudioManager408.Instance.ToggleSound();
        deniedSfx.gameObject.SetActive(PlayerPrefs.GetInt("SFX", 1) == 0);
    }

    public void Quit()
    {
        AudioManager408.Instance.PlaySound(0, 1);
        GameManager408.Instance.BackToMain();
        OnHide();
    }

    public override void OnHide()
    {
        AudioManager408.Instance.PlaySound(0, 1);
        base.OnHide();
        Time.timeScale = 1;
    }
}
