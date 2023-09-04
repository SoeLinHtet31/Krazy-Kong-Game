using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour
{
    public GameObject test;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Laser")
        {
            test.SetActive(false);
        }
    }
}
