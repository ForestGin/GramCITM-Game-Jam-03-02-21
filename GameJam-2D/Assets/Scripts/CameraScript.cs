using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    public GameObject player;
 
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.instance.player;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player != null)
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
