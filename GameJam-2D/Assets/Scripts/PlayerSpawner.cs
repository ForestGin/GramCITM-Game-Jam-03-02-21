using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    void Start()
    {
        if (player != null)
            player.GetComponent<PlayerMovement>().movement = gameObject.transform.position;        
    }
}
