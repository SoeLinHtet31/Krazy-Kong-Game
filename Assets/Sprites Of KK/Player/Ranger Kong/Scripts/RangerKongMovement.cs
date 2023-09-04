using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerKongMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;
    public BackGroundScroller Back;

    public bool isPressed;
    [SerializeField] private float attackCooldown;
    private float cooldownTimer = Mathf.Infinity;


    public VariableJoystick joysticks;

    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        moveLeft = false;
        moveRight = false;
    }

    void Update()
    {
        anim.SetBool("run", horizontalMove != 0);


        MovePlayer();

        


        if (joysticks.Direction.x >= 1 )
        {
            PointerDownRight();
        }
        else if (joysticks.Direction.x == 0)
        {
            PointerUpRight();
        }

        if (joysticks.Direction.x <= -1)
        {
            PointerDownLeft();
        }
        else if (joysticks.Direction.x == 0)
        {
            PointerUpLeft();
        }
        if (isPressed)
        {

            Attacks();
        }
        cooldownTimer += Time.deltaTime;



        flip();
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        anim.SetBool("aimTop", false);
        anim.SetBool("aimBot&MiD", false);
        anim.SetBool("aimToP&MiD", false);
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
        horizontalMove = 0;
    }

    public void PointerDownRight()
    {
        moveRight = true;
        anim.SetBool("aimTop", false);
        anim.SetBool("aimBot&MiD", false);
        anim.SetBool("aimToP&MiD", false);
    }

    public void PointerUpRight()
    {
        moveRight = false;
        horizontalMove = 0;
    }

    public void PointerUpTop()
    {
        anim.SetBool("aimTop", true);
    }
   

    public void PointerClickTopMid()
    {
        anim.SetBool("aimToP&MiD", true);
    }

    public void PointerClickBotMid()
    {
        anim.SetBool("aimBot&MiD", true);
    }

    public void OnPointerDown()
    {
        isPressed = true;
    }
    public void OnPointerUp()
    {
        isPressed = false;
    }



    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    public void Attacks()
    {
        if (cooldownTimer > attackCooldown)
        {
            anim.SetTrigger("Attack1");
            cooldownTimer = 0;
        }
    }
    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
        else if (moveRight)
        {
            horizontalMove = speed;

        }
        else
        {
            horizontalMove = 0;
        }
    }

    void flip()
    {
        if (horizontalMove < -0.01f) transform.localScale = new Vector3(1, 1, 1);
        if (horizontalMove > 0.01f) transform.localScale = new Vector3(-1, 1, 1);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "StartingWall")
            Back.speed = 0;
        else
            Back.speed = 1;

    }
}
