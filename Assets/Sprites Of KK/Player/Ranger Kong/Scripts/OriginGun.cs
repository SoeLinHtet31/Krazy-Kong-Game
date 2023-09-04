using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginGun : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] Bullets;

    private Animator anim;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        Bullets[FindBullets()].transform.position = FirePoint.position;
        Bullets[FindBullets()].GetComponent<OriginGunBullets>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindBullets()
    {
        for (int i = 0; i < Bullets.Length; i++)
        {
            if (!Bullets[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
