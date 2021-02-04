using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
   

    // Start is called before the first frame update
    void Start()
    {
        SetMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))//test if enemy dies
        {
            CurrentHealth -= 1;
        }

        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }

    public void HurtEnemy(int DamageToGive)
    {
        CurrentHealth -= DamageToGive;
    }

}
