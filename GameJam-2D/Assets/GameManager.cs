using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public  enum GameState { MAIN_MENU, GAME_OVER, TUTORIAL,IN_GAME }
    public static GameState gameState;
    public static GameManager instance;
    int index = 0;
    public GameObject playerPrefab;
    public GameObject audioManagerPrefab;
    [HideInInspector]
    public GameObject audioManager;
    [HideInInspector]
    public GameObject player;
    public delegate void StateChanged();
    public event StateChanged OnGameStateChanged;
    TransitionLoader transitionLoader;
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
        SpawnPlayer();
    }
    void Start()
    {
        transitionLoader = FindObjectOfType<TransitionLoader>();
    }
    public void SetCurrentGameState(GameState gameState)
    {
        switch(gameState)
        {
            case GameState.MAIN_MENU:
                //init all values
               // SceneManager.LoadScene(0);
                StartCoroutine(transitionLoader.LoadScene(0));
                if (player != null)
                    player.SetActive(false);
                break;
            case GameState.TUTORIAL:
                transitionLoader.LoadScene();
                if (player != null)
                    player.SetActive(true);
                player.transform.position = new Vector2(0, 0);
                break;
            case GameState.IN_GAME:
              //  SceneManager.LoadScene(2);
                StartCoroutine(transitionLoader.LoadScene(2));
                if (player != null)
                    player.SetActive(true);
                player.transform.position = new Vector2(0, 0);
                //add index if more levels, load each level
                
                break;
            case GameState.GAME_OVER:
                SceneManager.LoadScene(3);
                if (player != null)
                    player.SetActive(false);
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
    void SpawnAudioManager()
    {
        if (audioManager == null)
        {
            audioManager = Instantiate(audioManagerPrefab);
        }
        else
        { DestroyImmediate(player); }
    }
}
