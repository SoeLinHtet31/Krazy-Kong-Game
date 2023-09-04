using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigerEnter2D : MonoBehaviour
{
    private Transform StageStarting;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            GetComponent<BoxCollider2D>().enabled = false;
    }
}
