using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public float interactRange = 2f;
    public Transform player;


    private void Start()
    {
        if(player == null)
            player = GameManager.instance.player.transform;
    }
  
    void Update()
    {
        if (Vector2.Distance(gameObject.transform.position, player.position) < interactRange && Input.GetKeyDown(KeyCode.F) && player != null)
        {

            Debug.Log("Pos si q ha llegao aqui tocatge lñas nariconce");
                Interact();

            //interactionButton.onClick.AddListener(Interact);


        }
    }

    public virtual void Interact()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }

   
}
