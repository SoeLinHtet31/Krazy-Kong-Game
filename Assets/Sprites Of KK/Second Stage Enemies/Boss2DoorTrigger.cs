using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2DoorTrigger : MonoBehaviour
{
    public GameObject DoorTrigger;
    private Stage2MeleeEnemyHealth Health;

    private void Awake()
    {
        Health = GetComponent<Stage2MeleeEnemyHealth>();
    }

    private void FixedUpdate()
    {
        if(Health.currentHealth <= 0)
        {
            DoorTrigger.SetActive(true);
        }
        else if (Health.currentHealth > 0)
        {
            DoorTrigger.SetActive(false);
        }
    }

}
