using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecondStageBossHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;

    public bool canHurt;
    public bool canDie;

    [SerializeField] private StageClearResult Result;

    public GameObject BossHealthBar;

    public GameObject BossTrigger;

    public GameObject BossStartingPoint;

    public TextMeshProUGUI SKYBITTokenGain;

    public int _amountOfSKYBITGain;

    public float CheckHP;

    public bool invlurable;
    public bool isGrounded;

    public GameObject Flame;

    public GameObject Stage3TransferPlace;

    public CapsuleCollider2D cap;
    public BoxCollider2D box;
    private Rigidbody2D rb;

    public Rigidbody2D player;

    private void Awake()
    {

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        cap = GetComponent<CapsuleCollider2D>();
        canHurt = true;
        canDie = false;
        Flame.SetActive(false);
        box.enabled = true;
        cap.enabled = true;
    }
    private void Update()
    {
        SKYBITTokenGain.text = _amountOfSKYBITGain.ToString();
        CheckHP = currentHealth;
    }

    private void FixedUpdate()
    {
        if (currentHealth > 0)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            BossTrigger.SetActive(false);
            Stage3TransferPlace.SetActive(false);
            anim.SetBool("moving", true);
        }
        if (invlurable)
        {
            currentHealth = startingHealth;
        }


        if (currentHealth > 0 && canHurt)
        {
            canDie = true;
            anim.SetTrigger("hurt");
            BossHealthBar.SetActive(true);
        }

        if (currentHealth <= 0 && isGrounded)
        {
            rb.gravityScale = 0f;
        }
        else if (currentHealth <= 0 && !isGrounded)
        {
            rb.gravityScale = 100f;
        }

        if (isGrounded && currentHealth <= 0)
        {
            BossHealthBar.SetActive(false);
            anim.SetTrigger("die");
            canHurt = false;
            box.enabled = false;
            cap.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            Stage3TransferPlace.SetActive(true);
            anim.SetBool("moving", false);
            Flame.SetActive(false);
            player.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        if (isGrounded && currentHealth <= 0 && canDie)
        {
            canDie = false;
            _amountOfSKYBITGain = 100 + SKYBITToken.SkyBitTokengainAmount;
            Flame.SetActive(false);
            SKYBITToken.SkybitToken += 100 + _amountOfSKYBITGain;
            PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
            Invoke("resetTrigger", 43200f);
        }
    }

    public void FlameActive()
    {
        if (currentHealth > 0)
        {
            Flame.SetActive(true);
            Invoke("ReMove", 1f);
        }
        else if (currentHealth <= 0)
        {
            Flame.SetActive(false);
        }
    }

    public void RemoveColider()
    {
        cap.enabled = false;
    }

    public void ReMove()
    {
        Flame.SetActive(false);
    }

    public void EnRageMode()
    {
        canHurt = false;
        anim.SetTrigger("EnRageAttack");
    }

    public void EnableResult()
    {
        Result.EnableStageResult();
    }

    public void resetTrigger()
    {
        BossTrigger.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cap.enabled = false;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            cap.enabled = true;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        if (collision.tag == "Ground")
        {
            isGrounded = false;
        }
    }


    public void reset()
    {
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        canHurt = true;
        canDie = false;
        anim.Play("Stage2BossIdle");
        box.enabled = true;
        cap.enabled = true;
        currentHealth = startingHealth;
        gameObject.transform.position = BossStartingPoint.transform.position;
    }
}
