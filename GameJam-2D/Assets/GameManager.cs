using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { MAIN_MENU, GAME_OVER, TUTORIAL, IN_GAME }
    static GameState gameState;
    public static GameManager instance;
    int index = 0;
    public GameObject playerPrefab;
    public GameObject player;
    public delegate void StateChanged();
    public event StateChanged OnGameStateChanged;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }


    void Start()
    {
        SpawnPlayer();
    }
    public void SetCurrentGameState(GameState gameState)
    {
        switch (gameState)
        {
            case GameState.MAIN_MENU:
                //init all values
                SceneManager.LoadScene(0);

                break;
            case GameState.TUTORIAL:
                player.SetActive(true);
                SceneManager.LoadScene(1);
                break;
            case GameState.IN_GAME:
                SceneManager.LoadScene(2);
                //add index if more levels, load each level

                break;
            case GameState.GAME_OVER:
                SceneManager.LoadScene(3);
                break;
        }
    }
    void SpawnPlayer()
    {
        if (player == null)
        {
            player = Instantiate(playerPrefab);
            player.SetActive(false);
        }
        else
        { DestroyImmediate(player); }
    }
    void DespawnPlayer()
    {
        DestroyImmediate(player);
        player = null;
    }
}
