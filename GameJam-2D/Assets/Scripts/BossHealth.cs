using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public bool alive = false;
    public int MaxHealth;
    public int CurrentHealth;

    bool enraged = false;
    bool used = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        SetMaxHealth();
        enraged = false;
        used = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {

            if (enraged)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                //augmentar daño x2
            }

            if (CurrentHealth <= 0)
            {

                gameObject.SetActive(false);

            }

            if (!used && CurrentHealth <= MaxHealth / 2)
            {
                IsEnraged();
            }
        }
    }

    public void HurtingBoss(int damageToGiveBoss)
    {
        CurrentHealth -= damageToGiveBoss;
    }

    void IsEnraged()
    {
        gameObject.GetComponent<EnemyAI>().speed += 600;
        used = true;
        enraged = true;
            
        
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
