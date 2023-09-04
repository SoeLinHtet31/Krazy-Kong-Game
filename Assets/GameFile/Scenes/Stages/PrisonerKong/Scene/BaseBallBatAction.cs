using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBallBatAction : MonoBehaviour
{
    public Animator anim;
    public GameObject Player;

    public bool isPressed;
    public bool canAttack;

    public Animator player;

    private BaseBallBatData baseBallBat;

    public float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;

    public static int PCMode;
    public int CheckPCmode;

    public AudioSource BatSound;


    private void Start()
    {
        PCMode = 0;
        anim = Player.GetComponent<Animator>();
        cooldownTimer = 0;
        canAttack = true;
    }

    private void Awake()
    {
        baseBallBat = GetComponent<BaseBallBatData>();
    }

    private void Update()
    {
        if (PrisonerKongData.curentHealth <= 0)
        {
            canAttack = false;
            player.SetBool("canAttack", false);
            player.SetBool("canHurt", false);
        }
        else if (PrisonerKongData.curentHealth > 0)
        {
            player.SetBool("canAttack", true);
            player.SetBool("canHurt", true);
        }


        attackCooldown = baseBallBat.cooldown;
        CheckPCmode = PCMode;
        if (cooldownTimer < attackCooldown)
        {
            isPressed = false;
        }

        cooldownTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && !isPressed && PCMode >= 1 && canAttack)
        {
            anim.SetFloat("AttackSpeed", baseBallBat.attackSpeed);
            isPressed = true;
            anim.SetTrigger("Attack1");
            cooldownTimer = 0;
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            BatSound.Play();
            collision.GetComponent<EnemyHealth>().TakeDamage(baseBallBat.damage);
        }

        if (collision.tag == "TorretEnemy")
        {
            BatSound.Play();
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(baseBallBat.damage);
        }

        if (collision.name == "Stage2 Boss")
        {
            BatSound.Play();
            collision.GetComponent<SecondStageBossHealth>().TakeDamage(baseBallBat.damage);
        }


        if (collision.tag == "Boss")
        {
            BatSound.Play();
            collision.GetComponent<BossHealth>().TakeDamage(baseBallBat.damage);
        }

        if (collision.tag == "SecondStageEnemies")
        {
            BatSound.Play();
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(baseBallBat.damage);
        }


        if (collision.tag == "Stage2MeleeEnemy")
        {
            BatSound.Play();
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(baseBallBat.damage);
        }
 



    }
}
