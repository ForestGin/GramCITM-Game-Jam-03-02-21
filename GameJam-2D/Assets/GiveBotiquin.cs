using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBotiquin : Interactable
{
    public DialogueTrigger DT;
    public GameObject botiquinCanvas;
    public Healing healing;
    public GameObject go;

    private void Start()
    {
        
        go = GameObject.FindGameObjectWithTag("Player");
        healing = go.GetComponent<Healing>();
        healing.enabled = false;
    }
    public override void Interact()
    {

        base.Interact();
        botiquinCanvas.SetActive(true);
        if(healing.enabled == false)
        healing.enabled = true;
    }
}
