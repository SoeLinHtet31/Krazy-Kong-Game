using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDamagePlayer : MonoBehaviour
{
    public int Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PrisonerKongData.curentHealth -= Damage;
            Destroy(gameObject);
        }
    }
}
