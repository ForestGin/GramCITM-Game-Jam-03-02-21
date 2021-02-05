using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeSensor : MonoBehaviour
{

    GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        Spawner = transform.parent.gameObject; /*GameObject.Find("EnemySpawnPoint");*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Spawner.GetComponent<WaveSpawner>().alive = true;

        }

    }
}
