using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HurtEnemy : MonoBehaviour
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
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(DamageToGive);
            Instantiate(Burst, transform.position, transform.rotation);
        }

    }
}
