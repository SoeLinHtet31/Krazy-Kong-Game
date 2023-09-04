using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossHealth : MonoBehaviour
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

    public GameObject Flame;

    public GameObject Stage2TransferPlace;

    public CapsuleCollider2D cap;
    public BoxCollider2D box;

    public AudioSource Run;
    public AudioSource intro;

    public Rigidbody2D player;

    public BoxCollider2D EnRagePlace;



    private void Awake()
    {

    }
    private void Start()
    {
        intro.Play();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        cap = GetComponent<CapsuleCollider2D>();
        EnRagePlace.enabled = false;
        canHurt = true;
        canDie = false;
        Flame.SetActive(false);
    }
    private void Update()
    {
        SKYBITTokenGain.text = _amountOfSKYBITGain.ToString();
        CheckHP = currentHealth;
        if (currentHealth > 0)
        {
            BossTrigger.SetActive(false);
            Stage2TransferPlace.SetActive(false);
            anim.SetBool("moving", true);
        }
        if (invlurable)
        {
            currentHealth = startingHealth;
        }


        if (currentHealth <= 0)
        {
            canDie = true;
            box.enabled = false;
            cap.enabled = false;
            Stage2TransferPlace.SetActive(true);
            anim.SetBool("moving", false);
        }
        if (currentHealth <= 100 && currentHealth > 0)
        {
            canHurt = false;
            EnRagePlace.enabled = true;
        }

    }
    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;

        if (currentHealth > 0 && canHurt)
        {
            canDie = true;
            anim.SetTrigger("hurt");
            BossHealthBar.SetActive(true);
        }
        else if (currentHealth <= 0 && canDie)
        {
            _amountOfSKYBITGain = 50 + SKYBITToken.SkyBitTokengainAmount;
            Flame.SetActive(false);
            canHurt = false;
            canDie = false;
            anim.SetTrigger("die");
            SKYBITToken.SkybitToken += _amountOfSKYBITGain;
            PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
            Invoke("resetTrigger", 43200f);
            player.constraints = RigidbodyConstraints2D.FreezeAll;
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
        EnRagePlace.enabled = false;
        anim.SetBool("EnRage", false);
        BossTrigger.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyAttack")
        {
            anim.SetBool("EnRage", true);
        }
      
        if(collision.tag == "Player")
        {
            cap.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cap.enabled = true;
        }
    }

    public void reset()
    {
        canHurt = true;
        canDie = false;
        currentHealth = startingHealth;
        gameObject.transform.position = BossStartingPoint.transform.position;
        intro.Play();
    }
}
