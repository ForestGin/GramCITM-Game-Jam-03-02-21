using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    private PlayerHealthManager playerHealth;
    public float healRate = 5;
    private float nextHeal;
    public int healValor = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Time.deltaTime > nextHeal)
        {
            nextHeal = Time.deltaTime + healRate;
            playerHealth.HealPlayer(healValor);
        }
    }
}
