using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpcontroller : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Jump System")]
    [SerializeField] float jumpTime;
    [SerializeField] float jumpMultiplier;
    [SerializeField] int jumpPower;
    [SerializeField] float fallMultiplier;

    public GameObject GroundCHecker;

    private Animator anim;

    public bool canJump;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool IsGrounded;
    Vector2 vecGravity;

    public GameObject Player;
    public PrisonerKongData player;

    public VariableJoystick joystick;

    public GameObject box;

    public bool isJumping;
    float jumpCounter;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        anim = GetComponent<Animator>();
        player = GetComponent<PrisonerKongData>();
    }

    void Update()
    {


        IsGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.7473368f, 0.1858526f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        anim.SetBool("grounded", IsGrounded);

        if (Input.GetKey(KeyCode.Space) && IsGrounded)
        {
            anim.SetTrigger("jump");
            anim.SetBool("Jumping", true);
            box.SetActive(false);
        }



        if (rb.velocity.y < 0 && isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime) isJumping = false;

            float t = jumpCounter / jumpTime;
            float currentJumpM = jumpMultiplier;

            if (t > 0.5f)
            {
                currentJumpM = jumpMultiplier * (1 - t);
            }

            rb.velocity += vecGravity * currentJumpM * Time.deltaTime;
        }
        if (isJumping && !IsGrounded)
        {
            anim.SetBool("Jumping", false);
            player.canHurt = false;
            canJump = false;
        }


        if (rb.velocity.y < 0)
        {
            rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;
        }

        if (joystick.Direction.x == 0 && joystick.Direction.y == 1)
        {
            PointerClickJump();
        }

        if(PlayerMovement1.MobileMode >= 1 && IsGrounded)
        {
            Player.GetComponent<PlayerMovement1>().enabled = true;
        }

        if (PlayerMovement1.MobileMode >= 1 && IsGrounded && Time.timeScale == 0f)
        {
            Player.GetComponent<PlayerMovement1>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isJumping = false;
            canJump = true;
            box.SetActive(true);
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        isJumping = true;
        jumpCounter = 0;
    }


    public void PointerClickJump()
    {
        if (IsGrounded && canJump)
        {
            anim.SetTrigger("jump");
            anim.SetBool("Jumping", true);
            box.SetActive(false);
        }
    }
}
