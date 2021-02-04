using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : Interactable
{
    public DialogueBase[] DB;
    [HideInInspector] public int index;
    public bool nextDialogueOnInteract;

    private void Start()
    {
        if(nextDialogueOnInteract == true)
        {
            index = -1;
        }
        else
        {
            index = 0;
        }
    }

    public override void Interact()
    {
        if(nextDialogueOnInteract && !DialogueManager.instance.inDialogue)
        {
            Debug.Log("Llega??");
            if (index < DB.Length -1)
            {
                index++;
            }
        }

        DialogueManager.instance.EnqueueDialogue(DB[index]);
    }

    public void SetIndex(int i)
    {
        index = i;
    }
}
