﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int DamageToGive;
    public GameObject Burst;
    private GameObject e;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent(typeof(Transform)) as Transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(DamageToGive);
            other.gameObject.GetComponent<PlayerHealthManager>().hurt = true;
            e =  Instantiate(Burst, player.position, player.rotation);
            Destroy(e, 1f);
        }
    }
}
