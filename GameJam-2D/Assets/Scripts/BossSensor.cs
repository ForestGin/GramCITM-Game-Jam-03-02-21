using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSensor : MonoBehaviour
{
    private GameObject Boss;
    public GameObject BossPrefab;
    public Transform SpawnPosition;
    bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
      canSpawn = true;
        //Boss = GameObject.Find("Boss");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && canSpawn)
        {
            Boss = Instantiate(BossPrefab, SpawnPosition);
            Boss.transform.parent = null;
            Boss.transform.position = new Vector3(SpawnPosition.position.x, SpawnPosition.position.y, 0);
            Boss.SetActive(true);
            Boss.GetComponent<BossHealth>().alive = true;
            canSpawn = false;

        }

    }
}
