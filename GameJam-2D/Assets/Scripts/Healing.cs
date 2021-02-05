using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healing : MonoBehaviour
{
    private PlayerHealthManager playerHealth;
    public float healRate = 5;
    private float nextHeal;
    public int healValor = 1;
    public float timeCD = 5;
    public GameObject cdHeal;
    bool isOnCD;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<PlayerHealthManager>();
        
    }

    private void OnLevelWasLoaded()
    {
        cdHeal = GameObject.FindGameObjectWithTag("CDBotico");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Time.time > nextHeal)
        {
            isOnCD = true;
            timeCD = healRate;
            nextHeal = Time.time + healRate;
            playerHealth.HealPlayer(healValor);
           

        }
        if(isOnCD) CDUpdate();


    }

    void CDUpdate()
    {
        

        timeCD -= Time.deltaTime;
        cdHeal.GetComponent<Text>().text = timeCD.ToString("F0");
        if (timeCD < 0)
        {
            isOnCD = false;
            cdHeal.GetComponent<Text>().text = "";
        }


    }
}
