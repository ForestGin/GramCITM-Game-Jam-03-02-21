using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletprefab;

    public bool shoot = false;
    public float bulletForce = 100f;

    public float time_btw_shots = 0.1f;
    public float time_last_shot = 0;
    public float timeinmilisec = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) Shoot();

        timeinmilisec += Time.deltaTime;
    }

    void Shoot()
    {
        if (timeinmilisec > time_last_shot + time_btw_shots)
        {
            GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
            Rigidbody2D bullet_rb = bullet.GetComponent<Rigidbody2D>();
            bullet_rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

            time_last_shot = timeinmilisec + time_btw_shots;
        }
    }
}