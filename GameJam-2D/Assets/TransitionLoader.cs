using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene()
    {
        StartCoroutine(LoadLevel((SceneManager.GetActiveScene().buildIndex + 1)));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //play anim 
        transition.SetTrigger("Start");
        // wait
        yield return new WaitForSeconds(transitionTime);

        //loadscene;
        SceneManager.LoadScene(levelIndex);
    }
    public IEnumerator LoadScene(int levelIndex)
    {
        //play anim 
        transition.SetTrigger("Scene");
        // wait
        yield return new WaitForSeconds(transitionTime);

        //loadscene;
        SceneManager.LoadScene(levelIndex);
    }
}
