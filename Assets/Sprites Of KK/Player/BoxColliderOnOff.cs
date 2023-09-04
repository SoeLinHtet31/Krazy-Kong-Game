using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderOnOff : MonoBehaviour
{
    private PlayerMovement Player;
    private PlayerMovement1 _Player;

    private void Awake()
    {
        Player = GetComponentInParent<PlayerMovement>();
        _Player = GetComponentInParent<PlayerMovement1>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall")
        {
            Player.moveLeft = false;
            Player.moveRight = false;

            _Player.moveRight = false;
            _Player.moveRight = false;
        }

        if (collision.tag == "Ground")
        {
            GetComponent<CapsuleCollider2D>().isTrigger = false;
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            GetComponent<CapsuleCollider2D>().isTrigger = true;
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

}
