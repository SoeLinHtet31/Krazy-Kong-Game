using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] public GameObject Lasers;
    [SerializeField] private float attackCooldown;
    private float cooldownTimer = Mathf.Infinity;



    private void Awake()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown)
            Attack();
        cooldownTimer += Time.deltaTime;
    }

    void Attack()
    {
        cooldownTimer = 0;
        Lasers.transform.position = FirePoint.position;
        Lasers.SetActive(true);
    }


}
