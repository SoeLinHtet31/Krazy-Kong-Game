using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransferToStage1 : MonoBehaviour
{
    public Animator _Player;
    public GameObject _transformPlace;
    public Rigidbody2D Player;
    public Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.transform.position = _transformPlace.transform.position;
            _Player.SetTrigger("TransformToFirstPlace");
            Player.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
