using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1BossAttack : MonoBehaviour
{
    [Header("Attack Parameters")]
    [SerializeField] private float attackCooldown;
    [SerializeField] private float range;

    [Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private BoxCollider2D boxCollider;

    [Header("Player Layer")]
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    public BossHealth BossHp;
    public bool canAttack;

    //References
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        BossHp = GetComponentInParent<BossHealth>();
    }
    private void Awake()
    {

    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        //Attack only when player in sight?
        if (PlayerInSight())
        {

            if (cooldownTimer >= attackCooldown && BossHp.currentHealth >100)
            {
                cooldownTimer = 0;
                anim.SetBool("canAttack",true);
            }
        }
        else if (!PlayerInSight())
        {
            anim.SetBool("canAttack", false);
        }
    }

    public bool PlayerInSight()
    {

        RaycastHit2D hit =
            Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, playerLayer);

        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

}
