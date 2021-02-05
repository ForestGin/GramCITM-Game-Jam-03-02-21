using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HurtEnemy : MonoBehaviour
{
    public int DamageToGive;
    public GameObject BurstPrefab;
    private GameObject brust;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(DamageToGive);
            brust= Instantiate(BurstPrefab, transform.position, transform.rotation);
            Destroy(brust, 1f);
            other.gameObject.GetComponent<EnemyHealthManager>().hurt = true;
        }

    }
}
