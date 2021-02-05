using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button resume;
    public Button mainMenu;
    public GameObject pauseMenu;
    SoundFX am;
    void Start()
    {
        am = SoundFX.InstanceAM;
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                GameManager.instance.player.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                GameManager.instance.player.SetActive(true);
            }
        }

    }
    public void OnResume()
    {
        am.PlayAudio("ButtonSelect");
        pauseMenu.SetActive(false);
        GameManager.instance.player.SetActive(true);
        Time.timeScale = 1;
    }
    public void OnMainMenu()
    {
        am.PlayAudio("ButtonSelect");
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
