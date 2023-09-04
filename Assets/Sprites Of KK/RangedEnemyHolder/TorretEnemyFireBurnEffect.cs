using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretEnemyFireBurnEffect : MonoBehaviour
{
    public Transform fireEffect;
    public GameObject fire;
    public GameObject Enemy;

    public TorrretEnemyHealth enemyHealth;

    private void Update()
    {
        if (enemyHealth.currentHealth <= 0)
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

            Invoke("SetFalse", FlameDamageEffect.BurnDuration);
        }
        

    }
    void SetFalse()
    {

        fire.SetActive(false);
    }
}
