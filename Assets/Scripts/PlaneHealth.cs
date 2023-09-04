using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaneHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    public GameObject Enemy;

    public GameObject KongS;

    public Transform Kongs;

    public GameObject HealthBar;

    public GameObject Effect;

    private BoxCollider2D box;


    private CapsuleCollider2D CapCol;

    public GameObject Flame;

    public DroppingItems numberGenerator;
    public DroppingItems numberGenerator2;

    public TextMeshProUGUI number1;
    public TextMeshProUGUI number2;

    public GameObject ExpPotion;
    public GameObject PrisonerKongShard;

    public GameObject StartingPoint;


    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        CapCol = GetComponent<CapsuleCollider2D>();
    }

    private void Start()
    {
        box.enabled = true;
    }



    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            CapCol.enabled = true;
            Invoke("SetFalse", 0.5f);
        }
        else
        {
            if (!dead)
            {

                //Deactivate all attached component classes
                foreach (Behaviour component in components)
                    component.enabled = false;
                numberGenerator.RandomGenerate();
                numberGenerator2.RandomGenerate();
                dead = true;
                HealthBar.SetActive(false);

                //Drop items
                if (number1.text == "5" || (number1.text == "10") || (number1.text == "15") || (number1.text == "20") || (number1.text == "25") || (number1.text == "30"))
                {
                    PrisonerKongShard.SetActive(true);
                    PrisonerKongShard.transform.position = Enemy.transform.position;
                }
                else
                {
                    ExpPotion.SetActive(true);
                    ExpPotion.transform.position = Enemy.transform.position;

                    KongS.SetActive(true);
                    Kongs.transform.position = Enemy.transform.position;
                }
                if (number2.text == "5" || (number2.text == "10") || (number2.text == "15") || (number2.text == "20") || (number2.text == "25") || (number2.text == "30"))
                {
                    PrisonerKongShard.SetActive(true);
                    PrisonerKongShard.transform.position = Enemy.transform.position;
                }
                else
                {
                    ExpPotion.SetActive(true);
                    ExpPotion.transform.position = Enemy.transform.position;

                    KongS.SetActive(true);
                    Kongs.transform.position = Enemy.transform.position;
                }

                anim.SetTrigger("die");
                box.enabled = false;
                CapCol.enabled = false;
                Flame.SetActive(false);
                Effect.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CapCol.enabled = false;
        }

        if (collision.tag == "PlayerAttack")
        {
            GetComponentInParent<EnemyPatrol>().speed = 0f;
        }

        if (collision.tag == "BloodTrigger")
        {
            GetComponentInParent<EnemyPatrol>().speed = 0f;
        }

        Invoke("ReMove", 1f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CapCol.enabled = false;
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            CapCol.enabled = true;
        }
    }

    public void Deactivated()
    {
        Enemy.SetActive(false);
        Invoke("reset", 10f);
    }

    void SetFalse()
    {
        CapCol.enabled = false;
        Effect.SetActive(false);
    }

  

    private void reset()
    {
        gameObject.SetActive(true);
        anim.SetTrigger("idle");
        currentHealth = startingHealth;
        gameObject.transform.position = StartingPoint.transform.position;
    }
}

