using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] public Transform CheckPoint;
    [SerializeField] public Transform Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player.transform.position = CheckPoint.position;
        }

        if (collision.tag == "Player")
        {
            PrisonerKongData.curentHealth -= 10;
        }
    }
}
