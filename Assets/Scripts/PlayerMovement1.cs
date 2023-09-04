using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool moveLeft;
    public bool moveRight;
    public bool canMove;
    public bool ableToMove = true;
    public float horizontalMove;
    public float speed;

    public static int MobileMode;
    public int CheckMobileMode;

    Jumpcontroller jumpCon;

    public VariableJoystick joysticks;
    private Animator anim;

    public GameObject Joystick;

    public GameObject Player;


    void Start()
    {
        MobileMode = 0;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpCon = GetComponent<Jumpcontroller>();

        moveLeft = false;
        moveRight = false;
        canMove = true;
    }

    

    void Update()
    {
        CheckMobileMode = MobileMode;
        anim.SetBool("run", horizontalMove != 0);

        if (Input.touchCount > 0 || jumpCon.isJumping)
        {
            ableToMove = true;
        }
        else if (Input.touchCount <= 0 && jumpCon.isJumping == false)
        {
            ableToMove = false;
            moveRight = true;
            moveLeft = false;
        }

        speed = PrisonerKongData.PrisonerKongSpeed;

        if (moveLeft && Time.timeScale == 1f && canMove && ableToMove)
        {
            horizontalMove = -speed;
        }
        else if (moveRight && Time.timeScale == 1f && canMove && ableToMove)
        {
            horizontalMove = speed;

        }
        else if (!canMove && Time.timeScale == 1f )
        {
            horizontalMove = 0;
            ableToMove = false;
        }
        else
        {
            horizontalMove = 0;
        }

        if (joysticks.Direction.x == 1 && joysticks.Direction.y == 0 && canMove || joysticks.Direction.x == 1 && joysticks.Direction.y == 1 && canMove)
        {
            BaseBallActionMobile.MobileMoode += 1;
            MobileMode += 1;
            PointerDownRight();
        }
        else if (joysticks.Direction.x == 0 && joysticks.Direction.y == 0 || !canMove)
        {
            PointerUpRight();
        }

        if (joysticks.Direction.x == -1 && joysticks.Direction.y == 0 && canMove || joysticks.Direction.x == -1 && joysticks.Direction.y == 1 && canMove)
        {
            BaseBallActionMobile.MobileMoode += 1;
            MobileMode += 1;
            PointerDownLeft();
        }
        else if (joysticks.Direction.x == 0 && joysticks.Direction.y == 0 || !canMove)
        {
            PointerUpLeft();
        }

        flip();
    }


    public void PointerDownLeft()
    {
        moveLeft = true;
        moveRight = false;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
        horizontalMove = 0;
    }

    public void PointerDownRight()
    {
        moveRight = true;
        moveLeft = false;
        
    }

    public void PointerUpRight()
    {
        moveRight = false;
        horizontalMove = 0;
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            canMove = false;
        }

        if (collision.tag == "Ground")
        {
            canMove = true;
        }
    }
    void flip()
    {
        if (horizontalMove < -0.01f) transform.localScale = new Vector3(1, 1, 1);
        if (horizontalMove > 0.01f) transform.localScale = new Vector3(-1, 1, 1);
    }

    void Reattach()
    {
        Player.GetComponent<PlayerMovement1>().enabled = true;
        Player.GetComponent<Jumpcontroller>().enabled = true;
    }
}
