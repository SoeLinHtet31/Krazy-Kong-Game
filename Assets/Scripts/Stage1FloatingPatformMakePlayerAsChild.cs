using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1FloatingPatformMakePlayerAsChild : MonoBehaviour
{
    public GameObject playerHolder;
    public GameObject ParentTemp;
    public GameObject GroundCheck;
    public GameObject Player;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.parent = ParentTemp.transform;
            GroundCheck.transform.SetParent (Player.transform);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.parent = ParentTemp.transform;
            GroundCheck.transform.SetParent(Player.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.parent = playerHolder.transform;
            GroundCheck.transform.SetParent(Player.transform);
        }
    }

}
