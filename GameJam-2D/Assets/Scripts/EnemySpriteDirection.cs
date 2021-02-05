using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpriteDirection : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (gameObject.GetComponent<Rigidbody2D>().velocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
