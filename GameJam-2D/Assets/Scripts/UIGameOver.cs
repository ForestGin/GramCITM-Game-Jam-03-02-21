using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    Button restartBttn, mainMenuBttn;
   
    void Start()
    {
        restartBttn = transform.GetChild(2).GetComponent<Button>();
        restartBttn.onClick.AddListener(OnRestart);
        mainMenuBttn = transform.GetChild(3).GetComponent<Button>();
        mainMenuBttn.onClick.AddListener(OnMainMenu);
    }
    void OnRestart()
    {
        SceneManager.LoadScene(1);
    }
    void OnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
