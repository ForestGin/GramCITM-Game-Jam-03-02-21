using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    Button playBttn;
    void Start()
    {
        playBttn = transform.GetChild(2).GetComponent<Button>();
        playBttn.onClick.AddListener(OnStart);


    }
    void OnStart()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene(1);
    }

}
