using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    Button restartBttn, mainMenuBttn;
    SoundFX am;
    void Start()
    {

        am = SoundFX.InstanceAM;
        restartBttn = transform.GetChild(2).GetComponent<Button>();
        restartBttn.onClick.AddListener(OnRestart);
        mainMenuBttn = transform.GetChild(3).GetComponent<Button>();
        mainMenuBttn.onClick.AddListener(OnMainMenu);
    }
    void OnRestart()
    {
        am.PlayAudio("ButtonSelect");
        SceneManager.LoadScene(1);
    }
    void OnMainMenu()
    {
        am.PlayAudio("ButtonSelect");
        SceneManager.LoadScene(0);
    }

}
