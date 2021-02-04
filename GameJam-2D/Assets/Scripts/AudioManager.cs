using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager InstanceAM;

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
        PlayAudioByName("MainTheme");
        // ENEMIES.audioManager = this;
        // PLAYER.audioManager = this;
    }
    public void PlayAudioByName(string _name)
    {
        foreach (Sound s in sounds)
        {
            if(s.clipName  == _name)
             s.source.Play();
        }
    }
    //this one needs to have the name of the enemy name and the sound
    public void PlayAudio(string _name, string characterName)
    {
        switch (characterName)
        {
            case "Enemy01":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;
            case "Enemy02":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;
            case "Enemy03":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;
            case "Enemy04":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;
            case "Boss":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;
            case "Music":
                foreach (Sound s in sounds)
                {
                    if (s.clipName == _name + characterName)
                    {
                        s.source.Play();
                    }
                }
                break;

        }
    }
}
