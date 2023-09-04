using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollisionDetection : MonoBehaviour
{
    public float Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(Damage);
        }
        if (collision.tag == "Boss")
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(Damage);
        }
    }
}

