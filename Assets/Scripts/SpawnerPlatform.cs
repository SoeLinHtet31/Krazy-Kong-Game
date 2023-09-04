using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlatform : MonoBehaviour
{
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public bool isTimer;
    public GameObject objectToSpawn;

    private void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    private void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
            SpawnObject();


    }
    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

}
