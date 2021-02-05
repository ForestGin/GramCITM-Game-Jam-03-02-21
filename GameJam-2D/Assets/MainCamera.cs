using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    GameObject player;
    private void Awake()
    {
        if(player == null)
        {
            player = GameManager.instance.player;
        }
    }

}
