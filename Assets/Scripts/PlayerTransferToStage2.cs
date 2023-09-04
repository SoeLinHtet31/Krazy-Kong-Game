using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransferToStage2 : MonoBehaviour
{
    public Animator _Player;
    public GameObject transformPlace;
    public Rigidbody2D Player;
    public Transform player;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.transform.position = transformPlace.transform.position;
            _Player.SetTrigger("TransformToSecondPlace");
            Player.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

}
