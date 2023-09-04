using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadOnGateTrigger : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Gate gate;
    public GameObject DoorTigger;

    private void Start()
    {
    }

    private void Update()
    {
        if (enemyHealth.currentHealth <= 0)
        {
            DoorTigger.SetActive(true);         
        }
        else if (enemyHealth.currentHealth > 0)
        {
            DoorTigger.SetActive(false);
        }
    }
    

}
