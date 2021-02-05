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
                GameManager.instance.SetCurrentGameState(GameManager.GameState.MAIN_MENU);

            }

            if (!used && CurrentHealth <= MaxHealth / 2)
            {
                IsEnraged();
            }
            else if(CurrentHealth >= MaxHealth / 2)
            {
                gameObject.GetComponent<EnemyAI>().speed = 200;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(50);
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
