using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HurtBoss : MonoBehaviour
{
    public int DamageToGive;
    public GameObject Burst;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boss")
        {
            other.gameObject.GetComponent<BossHealth>().HurtingBoss(DamageToGive);
            Instantiate(Burst, transform.position, transform.rotation);
        }

    }
}
