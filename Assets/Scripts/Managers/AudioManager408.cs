using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager408 : Singleton408<AudioManager408>
{

    public SFX sfx;

    [SerializeField] private Sprite soundOn, soundOff, musicOn, musicOff; 
    
    
    public void ToggleMusic()
    {
        throw new System.NotImplementedException();
    }
    
    public void ToggleSound()
    {
        throw new System.NotImplementedException();
    }
    
    public void PlaySound(AudioClip clip)
    {
        throw new System.NotImplementedException();
    }
    
    public void PlayMusic(AudioClip clip)
    {
        throw new System.NotImplementedException();
    }
    
    
}

public enum SFX
{
    ButtonClick,
    PlayerMove,
    PlayerJump,
    PlayerHurt,
    CollectCoin,
    CollectEnergy
}
