using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2RangeEnemyAttack : MonoBehaviour
{
    [Header("Attack Parameters")]
    [SerializeField] private float attackCooldown;

    public float lineOfSite;
    private Transform player;

    public Transform arrowSpwanPoint;
    public GameObject arrowPrefeb;
    public float arrowSpeed;

    public bool isAttacking;
    public bool isFlipped = false;

    public Stage2EnemyRangerHealth Health;


    private float cooldownTimer = Mathf.Infinity;


    private Animator anim;
    public GameObject Player;
    public bool flip;
    public BoxCollider2D Box;



    public Transform SittingPlace;

    private void Start()
    {
        Box = GetComponent<BoxCollider2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        anim.SetBool("moving", false);
        Health = GetComponent<Stage2EnemyRangerHealth>();
    }

    private void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (cooldownTimer >= attackCooldown && distanceFromPlayer < lineOfSite)
        {
            isAttacking = true;
        }
        if (distanceFromPlayer < lineOfSite && isAttacking && Health.currentHealth > 0)
        {
            cooldownTimer = 0;
            anim.SetBool("canAttack", true);
        }
        else if (distanceFromPlayer > lineOfSite || Health.currentHealth <= 0)
        {
            anim.SetBool("canAttack", false);
            isAttacking = false;
        }
        cooldownTimer += Time.deltaTime;       
    }

    public void SpawnArrow()
    {
        var arrow = Instantiate(arrowPrefeb, arrowSpwanPoint.position, arrowSpwanPoint.rotation);
        arrow.GetComponent<Rigidbody2D>().velocity = arrowSpwanPoint.right * arrowSpeed;
    }

    public void LookAtThePlayer()
    {
        Vector3 flipped = transform.position;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && !isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(-1f, 1f, 1f);
            arrowSpwanPoint.transform.Rotate(0f, 0f, 180f);
            isFlipped = true;

        }
        else if (transform.position.x < player.position.x && isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(1f, 1f, 1f);
            arrowSpwanPoint.transform.Rotate(0f, 0f, 180f);
            isFlipped = false;
        }
    }




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Sitting Place")
        {
            anim.SetTrigger("Sitting");
        }

    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}