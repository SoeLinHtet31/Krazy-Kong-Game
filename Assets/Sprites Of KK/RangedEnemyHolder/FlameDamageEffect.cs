using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameDamageEffect : MonoBehaviour
{
    public static float BurnDuration;
    public static float BurnDamage;

    private void Awake()
    {
        BurnDuration = PlayerPrefs.GetFloat("BurnDuration", 1f);

        BurnDamage = PlayerPrefs.GetFloat("BurnDamage", 1f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(BurnDamage);
            collision.GetComponentInParent<EnemyPatrol>().speed = 0;
        }

        if (collision.tag == "TorretEnemy")
        {
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(BurnDamage);
        }



        if (collision.tag == "Boss")
        {
            collision.GetComponentInParent<BossHealth>().TakeDamage(BurnDamage);
        }


        if (collision.tag == "SecondStageEnemies")
        {
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(BurnDamage);
        }


        if (collision.tag == "Stage2MeleeEnemy")
        {
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(BurnDamage);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponentInParent<EnemyPatrol>().speed = 8;
        }

        if (collision.tag == "Boss")
        {
            collision.GetComponentInParent<FirstStageBossPatrol>().speed = 18;
        }       
    }
}






