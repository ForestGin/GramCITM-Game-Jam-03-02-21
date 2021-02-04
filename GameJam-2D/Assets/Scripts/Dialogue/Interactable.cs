using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public float interactRange = 2f;
    public Transform player;
    UnityEvent m_Event = new UnityEvent();


    private void Start() => player = GameObject.FindGameObjectWithTag("Player").transform;
    void Update()
    {
        if (Vector2.Distance(gameObject.transform.position, player.position) < interactRange)
        {
            if (Input.GetKeyDown(KeyCode.Space)) m_Event.AddListener(Interact);
            //interactionButton.onClick.AddListener(Interact);


        }
        else m_Event.RemoveListener(Interact);
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
