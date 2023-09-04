using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage2EnemyRangerHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;

    public GameObject KongS;

    public GameObject HealthBar;


    private BoxCollider2D box;


    public GameObject Flame;

    public DroppingItems numberGenerator;
    public DroppingItems numberGenerator2;

    public TextMeshProUGUI number1;
    public TextMeshProUGUI number2;

    public GameObject ExpPotion;
    public GameObject PrisonerKongShard;
    public GameObject BaseBallBatShard;
    public GameObject FlameThrowerShard;
    public GameObject MachineGunShard;
    public GameObject MichealKongShard;
    public GameObject PimpKongShard;

    public bool canDie;
    public bool canHurt;


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
    }

    private void Start()
    {
        box.enabled = true;
        canDie = false;
        canHurt = true;
    }

    private void Update()
    {

    }


    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        if (currentHealth > 0 && canHurt)
        {
            anim.SetTrigger("hurt");
            canDie = true;
        }
        else
        {
            if (currentHealth <= 0 && canDie)
            {
                //Deactivate all attached component classes
                foreach (Behaviour component in components)
                    component.enabled = false;
                numberGenerator.RandomGenerate();
                numberGenerator2.RandomGenerate();
                canDie = false;
                canHurt = false;
                anim.SetTrigger("die");
                Flame.SetActive(false);
            }
        }
    }

    public void Drop()
    {
        //Drop items
        if (number1.text == "5" || (number1.text == "10") || (number1.text == "15") || (number1.text == "20") || (number1.text == "25") || (number1.text == "30"))
        {
            PrisonerKongShard.SetActive(true);
            PrisonerKongShard.transform.position = gameObject.transform.position;
        }
        else if (number2.text == "35" || (number2.text == "40") || (number2.text == "45") || (number2.text == "50") || (number1.text == "55") || (number1.text == "60"))
        {
            BaseBallBatShard.SetActive(true);
            BaseBallBatShard.transform.position = gameObject.transform.position;
        }
        else if (number2.text == "8" || (number2.text == "13") || (number2.text == "18") || (number2.text == "23"))
        {
            FlameThrowerShard.SetActive(true);
            FlameThrowerShard.transform.position = gameObject.transform.position;
        }
        else if (number2.text == "9" || (number2.text == "14") || (number2.text == "19") || (number2.text == "24"))
        {
            MachineGunShard.SetActive(true);
            MachineGunShard.transform.position = gameObject.transform.position;
        }
        else if (number2.text == "6" || (number2.text == "11") || (number2.text == "16") || (number2.text == "21"))
        {
            MichealKongShard.SetActive(true);
            MichealKongShard.transform.position = gameObject.transform.position;
        }
        else if (number2.text == "7" || (number2.text == "12") || (number2.text == "17") || (number2.text == "22"))
        {
            PimpKongShard.SetActive(true);
            PimpKongShard.transform.position = gameObject.transform.position;
        }
        else
        {
            ExpPotion.SetActive(true);
            ExpPotion.transform.position = gameObject.transform.position;

            KongS.SetActive(true);
            KongS.transform.position = gameObject.transform.position;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            box.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            box.enabled = true;
        }
    }

    public void Deactivated()
    {
        gameObject.SetActive(false);
        Invoke("reset", 120f);
    }

    void ReMove()
    {
        Flame.SetActive(false);
    }

    private void reset()
    {
        currentHealth = startingHealth;
        canDie = false;
        canHurt = true;
        gameObject.SetActive(true);
        anim.SetTrigger("idle");
    }
}
