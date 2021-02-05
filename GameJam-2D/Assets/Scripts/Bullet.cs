using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Instantiate explosion 
        if (collision.gameObject.tag != "sensor")
            Destroy(gameObject);
        if (collision.gameObject.tag != "Background")
            SoundFX.InstanceAM.PlayAudio("Hit");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "sensor")
          Destroy(gameObject);
        if(collision.tag != "Background")
         SoundFX.InstanceAM.PlayAudio("Hit");
    }
}
