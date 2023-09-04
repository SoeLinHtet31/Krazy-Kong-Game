using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrisonerKongData : MonoBehaviour
{
    [Header("Health")]
    public static int PrisonerKongHealth;

    public static float PrisonerKongSpeed;

    public bool canDie;
    public bool canHurt;

    public static int gotHealthUpgrade;

    public GameObject player;


    public static int startingHealth;

    public static int curentHealth;

    private Animator anim;

    public bool IsDying = false;

    public TextMeshProUGUI level;

    public static int experience;
    public TextMeshProUGUI exp;
    public BaseBallBatAction Bat;
    public BaseBallActionMobile bat;

    public BoxCollider2D box;
    public Rigidbody2D rb;

    public int amountOfGotHealthUpgrade;
    
    public float Level;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;

    public GameOvermenu Gameover;
    private void Start()
    {
        curentHealth = PrisonerKongHealth;
        startingHealth = PrisonerKongHealth;
        canDie = false;
        canHurt = true;
    }

    private void Awake()
    {
        PrisonerKongHealth = PlayerPrefs.GetInt("PrisonerKongLevel", 0);

        rb = GetComponent<Rigidbody2D>();

        // Health
        PrisonerKongHealth = PlayerPrefs.GetInt("prisonerKongHealth", 200);

        // Movement Speed
        PrisonerKongSpeed = PlayerPrefs.GetFloat("PrisonerKongSpeed", 15f);


        // Experience
        experience = PlayerPrefs.GetInt("PrisonerKongExp", 0);

        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        exp.text = experience.ToString();

        if (experience >= 100 && experience < 199)
        {
            Level = 1f;
            level.text = "1" ;
        }

        if (experience >= 200 && experience < 299)
        {
            Level = 2f;
            level.text = "2";
        }

        if (experience >= 300 && experience < 399)
        {
            Level = 3f;
            level.text = "3";
        }

        if (experience >= 400 && experience < 499)
        {
            Level = 4f;
            level.text = "4";
        }

        if (experience >= 500 && experience < 599)
        {
            Level = 5f;
            level.text = "5";
        }

        if (experience >= 600 && experience < 699)
        {
            Level = 6f;
            level.text = "6";
        }

        if (experience >= 700 && experience < 799)
        {
            Level = 7f;
            level.text = "7";
        }

        if (experience >= 800 && experience < 899)
        {
            Level = 8f;
            level.text = "8";
        }

        if (experience >= 90 && experience < 999)
        {
            Level = 9f;
            level.text = "9";
        }

        if (experience >= 1000 && experience < 1099)
        {
            Level = 10f;
            level.text = "10";
        }

        if (experience >= 1100 && experience < 1199)
        {
            Level = 11f;
            level.text = "11";
        }

        if (experience >= 1200 && experience < 1299)
        {
            Level = 12f;
            level.text = "12";
        }


        if (experience >= 1300 && experience < 1399)
        {
            Level = 13f;
            level.text = "13";
        }

        if (experience >= 1400 && experience < 1499)
        {
            Level = 14f;
            level.text = "14";
        }

        if (experience >= 1500 && experience < 1599)
        {
            Level = 15f;
            level.text = "15";
        }


        if (experience >= 1600 && experience < 1699)
        {
            Level = 16f;
            level.text = "16";
        }

        if (experience >= 1700 && experience < 1799)
        {
            Level = 17f;
            level.text = "17";
        }

        if (experience >= 1800 && experience < 1899)
        {
            Level = 18f;
            level.text = "18";
        }

        if (experience >= 1900 && experience < 1999)
        {
            Level = 19f;
            level.text = "19";
        }

        if (experience >= 2000 && experience < 2099)
        {
            Level = 20f;
            level.text = "20";
        }

        if (experience >= 2100 && experience < 2199)
        {
            Level = 21f;
            level.text = "21";
        }

        if(gotHealthUpgrade > 0)
        {
            curentHealth = PrisonerKongHealth;
            startingHealth = PrisonerKongHealth;
        }

        amountOfGotHealthUpgrade = gotHealthUpgrade;

        if (curentHealth <= 0 && canDie && !IsDying)
        {
            player.GetComponent<PlayerMovement>().moveLeft = false;
            player.GetComponent<PlayerMovement>().moveRight = false;
            player.GetComponent<PlayerMovement1>().moveLeft = false;
            player.GetComponent<PlayerMovement1>().moveRight = false;

            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            anim.SetTrigger("die");
            anim.SetBool("canHurt", false);
            box.enabled = false;
            IsDying = true;
            canHurt = false;
            canDie = false;
            //Deactivate all attached component classes
            foreach (Behaviour component in components)
                component.enabled = false;
        }



        if (PrisonerKongSpeed == 15)
        {
            anim.SetFloat("MovementSpeed", 2.0f);
        }
        if(PrisonerKongSpeed == 16)
        {
            anim.SetFloat("MovementSpeed", 2.1f);
        }
        if (PrisonerKongSpeed == 17)
        {
            anim.SetFloat("MovementSpeed", 2.2f);
        }
        if (PrisonerKongSpeed == 18)
        {
            anim.SetFloat("MovementSpeed", 2.2f);
        }
        if (PrisonerKongSpeed == 19)
        {
            anim.SetFloat("MovementSpeed", 2.3f);
        }
        if (PrisonerKongSpeed == 20)
        {
            anim.SetFloat("MovementSpeed", 2.4f);
        }
        if (PrisonerKongSpeed == 21)
        {
            anim.SetFloat("MovementSpeed", 2.5f);
        }
        if (PrisonerKongSpeed == 22)
        {
            anim.SetFloat("MovementSpeed", 2.6f);
        }
        if (PrisonerKongSpeed == 23)
        {
            anim.SetFloat("MovementSpeed", 2.7f);
        }
        if (PrisonerKongSpeed == 24)
        {
            anim.SetFloat("MovementSpeed", 2.8f);
        }
        if (PrisonerKongSpeed >= 25)
        {
            anim.SetFloat("MovementSpeed", 2.9f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyAttack")
        {
            if (curentHealth > 0 && canHurt)
            {
                anim.SetTrigger("hurt");
                anim.SetBool("canHurt",true);
                canDie = true;
            }
        }
    }

    public void GameOverTrigger()
    {
        Gameover.EnableGameOverMenu();
    }
    
    public void ResetAttack1()
    {
        bat.canAttack = true;
        Bat.canAttack = true;
    }


    public void Respawn()
    {
        IsDying = false;
        bat.canAttack = true;
        Bat.canAttack = true;
        box.enabled = true;
        anim.Play("Idle");
        canHurt = true;
        curentHealth = PrisonerKongHealth;
    }
}
