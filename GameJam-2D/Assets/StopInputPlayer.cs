using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopInputPlayer : MonoBehaviour
{
    DialogueManager dm;
    PlayerMovement pm;
    PlayerShooting ps;
    private void Start()
    {
        pm = GetComponent<PlayerMovement>();
        ps = GetComponent<PlayerShooting>();
        dm = DialogueManager.instance;
    }
    void Update()
    {
        if (dm != null)
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

  
}
