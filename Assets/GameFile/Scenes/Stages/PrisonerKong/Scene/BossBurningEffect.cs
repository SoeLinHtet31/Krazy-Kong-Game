using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBurningEffect : MonoBehaviour
{
    public Transform fireEffect;
    public GameObject fire;
    public GameObject Enemy;

    public static float BurnDuration;
    public static float BurnDamage;

    public BossHealth BossHealth;

    private void Awake()
    {
        BurnDuration = PlayerPrefs.GetFloat("BurnDuration", 1f);

        BurnDamage = PlayerPrefs.GetFloat("BurnDamage", 0.5f);
    }

    private void Update()
    {
        if (BossHealth.currentHealth <= 0)
        {
            fire.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FireTrigger")
        {
            fire.SetActive(true);
            fireEffect.transform.position = Enemy.transform.position;
            Invoke("SetFalse", BurnDuration);
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Fire")
        {
            GetComponentInParent<FirstStageBossPatrol>().speed = 0f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Fire")
        {
            GetComponentInParent<FirstStageBossPatrol>().speed = 18f;
        }
    }
    void SetFalse()
    {

        fire.SetActive(false);
    }
}
