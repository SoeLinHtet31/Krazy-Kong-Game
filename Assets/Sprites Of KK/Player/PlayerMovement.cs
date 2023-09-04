using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool moveLeft;
    public bool moveRight;
    public float horizontalMove;
    public float speed;


    private Animator anim;

    public static int PCMode;
    public int CheckPCMode;

    void Start()
    {

        PCMode = 0;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        moveLeft = false;
        moveRight = false;
    }

    void Update()
    {
        if (moveLeft && Time.timeScale == 1f)
        {
            horizontalMove = -speed;
        }
        else if (moveRight && Time.timeScale == 1f)
        {
            horizontalMove = speed;

        }
        else
        {
            horizontalMove = 0;
        }

        if(Time.timeScale == 0f)
        {
            moveLeft = false;
            moveRight = false;
        }

        CheckPCMode = PCMode;
        anim.SetBool("run", horizontalMove != 0);

        speed = PrisonerKongData.PrisonerKongSpeed;
  

        if (Input.GetKeyDown(KeyCode.D) && Time.timeScale == 1f)
        {
            PointerDownRight();
        }


        if (Input.GetKeyUp(KeyCode.D))
        {
            PointerUpRight();
        }


        if (Input.GetKeyDown(KeyCode.A) && Time.timeScale == 1f)
        {
            PointerDownLeft();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            PointerUpLeft();
        }



        flip();
    }


    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
        horizontalMove = 0;
    }

    public void PointerDownRight()
    {
        moveRight = true;
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
            moveRight = false;
            moveLeft = false;
        }
       

    }


    void flip()
    {
        if (horizontalMove < -0.01f) transform.localScale = new Vector3(1, 1, 1);
        if (horizontalMove > 0.01f) transform.localScale = new Vector3(-1, 1, 1);
    }
}
