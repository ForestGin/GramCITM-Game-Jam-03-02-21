using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    public GameObject e;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            SoundFX.InstanceAM.PlayAudio("HitMiss");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "Spawner")
        {
            Destroy(gameObject);
            SoundFX.InstanceAM.PlayAudio("Hit");
            e = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(e, 1);
        }
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
            SoundFX.InstanceAM.PlayAudio("HitMiss");

            e = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(e, 1);
        }
 
    }
}
