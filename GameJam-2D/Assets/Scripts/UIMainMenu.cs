using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    Button playBttn;
    SoundFX am;
    void Start()
    {
        am = SoundFX.InstanceAM;
        playBttn = transform.GetChild(2).GetComponent<Button>();
        playBttn.onClick.AddListener(OnStart);
    }
    void OnStart()
    {
        am.PlayAudio("ButtonSelect");
        Debug.Log("Game Started");
        SceneManager.LoadScene(1);
    }

}
