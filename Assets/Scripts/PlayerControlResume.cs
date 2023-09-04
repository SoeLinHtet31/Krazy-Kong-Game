using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlResume : MonoBehaviour
{
    public GameObject _Player;
    public GameObject BaseBallBat;
    public Rigidbody2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        if (collision.tag == "Player")
        {
            _Player.GetComponent<PlayerControlOption>().enabled = true;
            if (PlayerMovement.PCMode >= 1)
            {
                _Player.GetComponent<PlayerMovement>().enabled = true;
            }

            if (PlayerMovement1.MobileMode >= 1)
            {
                _Player.GetComponent<PlayerMovement1>().enabled = true;
            }

            _Player.GetComponent<Jumpcontroller>().enabled = true;

            if (BaseBallBatAction.PCMode >= 1)
            {
                BaseBallBat.GetComponent<BaseBallBatAction>().enabled = true;
            }

            if (BaseBallActionMobile.MobileMoode >= 1)
            {
                BaseBallBat.GetComponent<BaseBallActionMobile>().enabled = true;
            }
        }
    }
}
