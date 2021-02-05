using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSensor : MonoBehaviour
{
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        //Boss = GameObject.Find("Boss");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Boss.SetActive(true);
            Boss.GetComponent<BossHealth>().alive = true;

        }

    }
}
