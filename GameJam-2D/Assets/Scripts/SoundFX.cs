using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundFX : MonoBehaviour
{
    public Sound[] sounds;
    public static SoundFX InstanceAM;
    public bool mute;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (InstanceAM == null)
        {
            InstanceAM = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        mute = false;
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.volume = s.volume;
            s.source.loop = s.loop;
            s.source.clip = s.clip;
            s.source.name = s.clipName;
        }
    }
    private void Start()
    {
        PlayAudio("MainTheme");
        // ENEMIES.audioManager = this;
        // PLAYER.audioManager = this;
    }
    public void PlayAudio(string _name)
    {
        foreach (Sound s in sounds)
        {
            if(s.source.name == _name)
             s.source.Play();
        }
    }
   public void Mute()
   {
        mute = !mute;
        if (mute)
        {
            foreach (Sound s in sounds)
            {

                s.source.volume = 0;
            }
        }
        else
        {
            foreach (Sound s in sounds)
            {

                s.source.volume = s.volume;
            }
        }
   }
}
