using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    private HealthBar HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        SetMaxHealth();
    }
    private void OnEnable()
    {
        HealthBar = FindObjectOfType<HealthBar>();
        SetMaxHealth();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))//test if enemy dies
        {
            HurtPlayer(1);
        }

        if (CurrentHealth <= 0)
        {
            GameManager.instance.SetCurrentGameState(GameManager.GameState.GAME_OVER);
            gameObject.SetActive(false);
        }
    }

    void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }

    public void HurtPlayer(int DamageToGive)
    {
        CurrentHealth -= DamageToGive;
        if (HealthBar != null)
        {
            HealthBar.SetHealthBar(CurrentHealth);
        }
        else
        {
            HealthBar = FindObjectOfType<HealthBar>();
        }
    }
}
