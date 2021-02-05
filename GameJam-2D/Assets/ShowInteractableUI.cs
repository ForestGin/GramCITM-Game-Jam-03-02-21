using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInteractableUI : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public GameObject infoBoxInteract;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            infoBoxInteract.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            infoBoxInteract.SetActive(false);
        }
    }

}
