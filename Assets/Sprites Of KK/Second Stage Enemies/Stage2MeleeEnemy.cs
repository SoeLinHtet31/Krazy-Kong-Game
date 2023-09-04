using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2MeleeEnemy : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float Facing;
    public float MeleeRange;

    public Transform player;

    public GameObject Chair;
    public Transform stittingPlace;
    public BoxCollider2D StittingPlace;
    public BoxCollider2D SittingTracker;
    public bool isFlipped = false;
    public bool Flip;

    [SerializeField] private float attackCooldown;
    private float cooldownTimer = Mathf.Infinity;


    public bool canAttack;
    public bool canMove;
    public bool goToIdlePlace;
    public bool setSittingPlace;
    public bool isAttacking;

    public float Speed = 15f;
    public Transform _StittingPlace;
    public Transform _player;
    private Rigidbody2D rb;

    public bool turnBack;

    private Stage2MeleeEnemyHealth Health;

    private Animator anim;

    private void Awake()
    {
        Health = GetComponent<Stage2MeleeEnemyHealth>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        isAttacking = false;
        canAttack = false;
        canMove = false;
        goToIdlePlace = false;
        SittingTracker.enabled = false;
        StittingPlace.enabled = false;
        anim.SetBool("SitAble", false);
        setSittingPlace = false;
        anim.SetBool("canAttack", false);
    }
    private void Update()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSite && distanceFromPlayer > MeleeRange && Health.currentHealth > 0)
        {
            canMove = true;
            goToIdlePlace = false;
            turnBack = false;
            canAttack = false;
            anim.SetBool("canAttack", false);
            isAttacking = false;          
        }

        if(distanceFromPlayer > MeleeRange && canMove && Health.currentHealth > 0)
        {
            LookAtThePlayer();
            Vector2 target = new Vector2(_player.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, Speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }


        if(distanceFromPlayer > lineOfSite && distanceFromPlayer < Facing && Health.currentHealth > 0)
        {
            isAttacking = false;
            goToIdlePlace = true;
            turnBack = true;
            canAttack = false;
            canMove = false;
            isFlipped = false;
            anim.SetBool("canAttack", false);
        }

        if (distanceFromPlayer < MeleeRange && !isAttacking && Health.currentHealth > 0)
        {
            isAttacking = true;
            canAttack = true;
            goToIdlePlace = false;
            turnBack = false;
            canMove = false;
            setSittingPlace = false;
            anim.SetBool("moving", false);
        }

        if (Health.currentHealth <= 0)
        {
            canMove = false;
            canAttack = false;
            goToIdlePlace = false;
        }

        cooldownTimer += Time.deltaTime;

        if (canAttack)
        {
            if (cooldownTimer >= attackCooldown)
            {
                cooldownTimer = 0;
                anim.SetBool("canAttack",true);
            }
        }


        if (canMove)
        {           
            anim.SetBool("moving", true);
        }

        if (goToIdlePlace)
        {
            SittingTracker.enabled = true;
            setSittingPlace = true;

            TurnBack();
            Vector2 target = new Vector2(_StittingPlace.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, Speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }
        else
        {
            setSittingPlace = false;
            SittingTracker.enabled = false;
        }
    }

    public void FixedUpdate()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if (transform.position.x > player.position.x && distanceFromPlayer > lineOfSite && distanceFromPlayer < Facing)
        {
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && distanceFromPlayer > lineOfSite && distanceFromPlayer < Facing)
        {
            isFlipped = true;
        }
    }

    public void LookAtThePlayer()
    {
        Vector3 flipped = transform.position;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && !isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(-1f, 1f, 1f);
            isFlipped = true;
            Flip = false;
        }
        else if (transform.position.x < player.position.x && isFlipped )
        {
            transform.position = flipped;
            transform.localScale = new Vector3(1f, 1f, 1f);
            isFlipped = false;
            Flip = false;
        }
    }
  

    public void TurnBack()
    {
        Vector3 flipped = transform.position;
        flipped.z *= -1f;

        if (transform.position.x > stittingPlace.position.x && !Flip)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(-1f, 1f, 1f);
            Flip = true;
        }
        else if (transform.position.x < stittingPlace.position.x && !Flip)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(1f, 1f, 1f);
            Flip = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerRange" && setSittingPlace)
        {
            StittingPlace.enabled = true;
            SittingTracker.enabled = false;
        }

        if (collision.name == "RightPlace")
        {
            gameObject.transform.position = Chair.transform.position;
        }

        else if (collision.name == "LeftPlace")
        {
            gameObject.transform.position = Chair.transform.position;
        }

        if (collision.tag == "Sitting Place")
        {
            canMove = false;
            goToIdlePlace = false;
            StittingPlace.enabled = false;
            anim.SetBool("moving", false);
            anim.SetBool("SitAble", true);
            setSittingPlace = false;
        }
        else if (collision.tag == "Sitting Place")
        {
            canMove = false;
            goToIdlePlace = false;
            StittingPlace.enabled = false;
            anim.SetBool("moving", false);
            anim.SetBool("SitAble", true);
            setSittingPlace = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            anim.SetBool("SitAble", false);
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, MeleeRange);
        Gizmos.DrawWireSphere(transform.position, Facing);
    }
   
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
