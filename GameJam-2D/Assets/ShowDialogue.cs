using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    public TextMeshPro DialogueInteractUI;
    public TextMeshPro DialogueShootedUI;

    Collider colliderDialogue;

    // Start is called before the first frame update
    void Start()
    {
        colliderDialogue = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DialogueInteractUI.gameObject.SetActive(true);
        }
        if (other.gameObject.tag == "Bullet")
        {
            DialogueShootedUI.gameObject.SetActive(true);
        }
    }
}
