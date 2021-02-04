using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    Button restartBttn, mainMenuBttn;
   
    void Start()
    {
        restartBttn = transform.GetChild(1).GetComponent<Button>();
        restartBttn.onClick.AddListener(OnRestart);
        mainMenuBttn = transform.GetChild(2).GetComponent<Button>();
        mainMenuBttn.onClick.AddListener(OnMainMenu);
    }
    void OnRestart()
    {
        Debug.Log("Game Restarted");
    }
    void OnMainMenu()
    {
        Debug.Log("OnMainMenu");
    }

}
