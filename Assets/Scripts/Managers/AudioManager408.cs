using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager408 : Singleton408<AudioManager408>
{


    [SerializeField] private AudioClip musicClip;
    [SerializeField] private AudioClip[] soundClips;

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public bool isMusicOn;
    public bool isSfxOn;



    protected override void OnInit()
    {
        base.OnInit();
        PlayMusic(musicClip , 1);
    }


    public void ToggleMusic()
    {
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            PlayerPrefs.SetInt("Music", 0);
            musicSource.Stop();
        }
        else
        {
            PlayerPrefs.SetInt("Music", 1);
            musicSource.Play();
        }

   
    }
    
    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("SFX" , 1) == 1)
            PlayerPrefs.SetInt("SFX", 0);
        else
            PlayerPrefs.SetInt("SFX", 1);
    }

    public void PlaySound(int id, float vol)
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 0) return;
        sfxSource.PlayOneShot(soundClips[id], vol);
    }
    
    public void PlayMusic(AudioClip clip, float vol)
    {
        if (PlayerPrefs.GetInt("Music", 1) == 0) return;
        musicSource.clip = clip;
        musicSource.volume = vol;
        musicSource.Play();
    }
    
    
}

