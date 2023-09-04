using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PrisonerKongData.PrisonerKongHealth -= 10;
        }
    }
}