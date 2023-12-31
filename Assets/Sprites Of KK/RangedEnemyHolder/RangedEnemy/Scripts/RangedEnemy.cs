using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RangedEnemy : MonoBehaviour
{
    [Header("Attack Parameters")]
    [SerializeField] private float attackCooldown;
    [SerializeField] private float range;

    [Header("Ranged Attack")]
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject[] Bullets;

    [Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private BoxCollider2D boxCollider;

    [Header("Player Layer")]
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    //References
    private Animator anim;
    private EnemyPatrol enemyPatrol;

    public bool isAttacking;

    private void Start()
    {
        isAttacking = false;
    }
    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyPatrol = GetComponentInParent<EnemyPatrol>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        //Attack only when player in sight?
        if (PlayerInSight())
        {
            isAttacking = true;
            anim.SetBool("canAttack", true);
            if (cooldownTimer >= attackCooldown)
            {
                cooldownTimer = 0;
                anim.SetTrigger("RangedAttack");
            }
        }
        else if (!PlayerInSight())
        {
            isAttacking = false;
            anim.SetBool("canAttack", false);
        }

        if (enemyPatrol != null)
        {
            enemyPatrol.enabled = !PlayerInSight();
        }
    }

    private void RangedAttack()
    {
        cooldownTimer = 0;
        Bullets[FindBullets()].transform.position = firepoint.position;
        Bullets[FindBullets()].GetComponent<EnemyProjectile>().ActivateProjectile();
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

    private bool PlayerInSight()
    {
        RaycastHit2D hit =
            Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0,playerLayer);

        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
