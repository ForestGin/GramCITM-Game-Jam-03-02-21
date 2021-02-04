using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    Text displayText;
    Button audioButton;
    SoundFX am;
    void Start()
    {
        audioButton = GetComponent<Button>();
        audioButton.onClick.AddListener(OnClick);
        displayText = GetComponentInChildren<Text>();

        am = SoundFX.InstanceAM;
    }
    
    void OnClick()
    {
        am.PlayAudio("ButtonSelect");
        am.Mute();
        if (am.mute)
        {
            displayText.text = "MUSIC: OFF";
        }
        else
        {
            displayText.text = "MUSIC: ON";
        }
    }
}
