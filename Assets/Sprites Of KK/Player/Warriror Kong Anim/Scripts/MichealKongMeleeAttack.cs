using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichealKongMeleeAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;

    private Animator anim;
    private float cooldownTimer = Mathf.Infinity;



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
            anim.SetTrigger("Attack1");

        cooldownTimer += Time.deltaTime;
    }
}
