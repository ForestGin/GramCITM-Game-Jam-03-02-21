using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class EnemyHealthManager : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;

    public bool hurt = false;

    SpriteRenderer enemy_spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        enemy_spriteRenderer = gameObject.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
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

        if (!hurt) enemy_spriteRenderer.color = Color.white;
        else if (hurt)
        {
            enemy_spriteRenderer.color = Color.red;
            hurt = false;
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
