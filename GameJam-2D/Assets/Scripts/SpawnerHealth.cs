using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHealth : MonoBehaviour
{

    Transform parent;

    public int HP = 0;
    public int CurrentHP = 0;
    // Start is called before the first frame update
    
    void Start()
    {
        parent = transform.root;
        SetMaxHP();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHP <= 0)
        {
            Destroy(parent.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.tag == "Bullet")
         {
                CurrentHP -= 1;

         }
        

    }

    void SetMaxHP()
    {
        CurrentHP = HP;
    }
}
