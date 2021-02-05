using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopInputPlayer : MonoBehaviour
{
    PlayerMovement pm;
    PlayerShooting ps;
    private void Start()
    {
        pm = GetComponent<PlayerMovement>();
        ps = GetComponent<PlayerShooting>();
    }
    void Update()
    {
        if (DialogueManager.instance.inDialogue)
        {
            pm.enabled = false;
            ps.enabled = false;

        }
        else
        {
            pm.enabled = true;
            ps.enabled = true;
        }
    }

  
}
