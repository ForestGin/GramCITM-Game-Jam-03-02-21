using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "New Profile", menuName = "Character Profile")]
public class CharacterProfile : ScriptableObject
{
    public string myName;
    private Sprite myPortrait;
    public AudioClip myVoice;
    public GameObject myFont;

    public Sprite MyPortrait
    {
        get
        {
            //add stuff here
            SetEmotionType(Emotion);
            return myPortrait;
        }
    }


    [System.Serializable]
    public class EmotionPortraits
    {
        public Sprite standard;
        public Sprite happy;
        public Sprite sad;
        public Sprite angry;
    }

    public EmotionPortraits emotionPortraits;

    public EmotionType Emotion { get; set; }

    public void SetEmotionType(EmotionType newEmotion)
    {
        Emotion = newEmotion;
        switch(Emotion)
        {
            case EmotionType.Standar:
                myPortrait = emotionPortraits.standard;
                break;

            case EmotionType.Happy:
                myPortrait = emotionPortraits.happy;
                break;

            case EmotionType.Sad:
                myPortrait = emotionPortraits.sad;
                break;

            case EmotionType.Angry:
                myPortrait = emotionPortraits.angry;
                break;
        }
    }
}

public enum EmotionType
{
    Standar,
    Happy,
    Sad,
    Angry
}
