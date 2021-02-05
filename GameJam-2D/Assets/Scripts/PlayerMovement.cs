using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Movement_Speed = 5f;


    public Rigidbody2D player_rb;
    public Rigidbody2D weapon_rb;

    public GameObject weapon;
    public Camera cam;

    Vector2 movement;
    Vector2 mouse_position;

    SpriteRenderer player_spriteRenderer;
    SpriteRenderer weapon_spriteRenderer;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        cam = Camera.main;
        weapon_rb = weapon.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        player_spriteRenderer = gameObject.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        weapon_spriteRenderer = weapon.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
    }

    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mouse_position = cam.ScreenToWorldPoint(Input.mousePosition);

        if (movement.x >= 0.01f)
        {
            player_spriteRenderer.flipX = false;
        }
        else if (movement.x <= -0.01f)
        {
            player_spriteRenderer.flipX = true;
        }

    }

    private void FixedUpdate()
    {
        //Movement
        player_rb.MovePosition(player_rb.position + movement * Movement_Speed * Time.fixedDeltaTime);

        Vector2 lookdir = mouse_position - player_rb.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        weapon_rb.rotation = angle;
        weapon_rb.position = player_rb.position;

        if (angle >= 0) weapon_spriteRenderer.flipX = true;

        else weapon_spriteRenderer.flipX = false;
    }


}
