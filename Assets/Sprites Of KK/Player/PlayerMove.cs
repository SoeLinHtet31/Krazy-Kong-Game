using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 move;
    public int speed;

    private Animator anim;

    float h;

    Rigidbody2D rb;

    private bool FacingRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("run", move.x != 0);



        anim.SetBool("aimTop", Input.GetKeyDown(KeyCode.W));
        anim.SetBool("aimMiddle", Input.GetKeyDown(KeyCode.S));
        anim.SetBool("aimToP&Run", move.x != 0);
        anim.SetBool("aimToP&MiD", Input.GetKeyDown(KeyCode.Q));
        anim.SetBool("aimToP&MiD&Run", move.x != 0);
        anim.SetBool("aimBot&MiD", Input.GetKeyDown(KeyCode.E));
        anim.SetBool("aimBot&MiD&Run", move.x != 0);

       

        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += new Vector3(move.x, move.y, 0) * speed * Time.deltaTime;

        transform.Translate(move * speed * Time.deltaTime);

        flip();

        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (mousePos.x < transform.position.x && FacingRight)
        {
            Flip();
        }
        else if (mousePos.x > transform.position.x && !FacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        Vector3 tmpScale = transform.localScale;
        tmpScale.x = -tmpScale.x;
        transform.localScale = tmpScale;
        FacingRight = !FacingRight;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
    }


    void flip()
    {
        if (move.x < -0.01f) transform.localScale = new Vector3(1, 1, 1);
        if (move.x > 0.01f) transform.localScale = new Vector3(-1, 1, 1);
    }
}
