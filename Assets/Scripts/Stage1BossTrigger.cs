using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1BossTrigger : MonoBehaviour
{
    public BossHealth boss;
    public GameObject Boss;
    public Animator BossAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Boss.SetActive(true);
            boss.reset();
            BossAnim.Play("Idle");
        }
    }
}
