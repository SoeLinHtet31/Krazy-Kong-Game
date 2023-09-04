using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2BossDoor2 : MonoBehaviour
{
    public Animator Door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Door.SetTrigger("Close");
        }
    }
}
