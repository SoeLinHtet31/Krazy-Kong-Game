using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1BossRun : StateMachineBehaviour
{
    public float speed = 25f;
    Transform player;
    Transform EnRagePlace;
    Rigidbody2D rb;
    Stage1Boss boss;
    Stage1BossAttack Boss;
    BossHealth BossHP;
    public bool canRun;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        EnRagePlace = GameObject.FindGameObjectWithTag("EnemyAttack").transform;
        BossHP = animator.GetComponent<BossHealth>();
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Stage1Boss>();
        Boss = animator.GetComponent<Stage1BossAttack>();
        canRun = true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();
        if (canRun)
        {
            Vector2 target = new Vector2(player.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }
        else if (Boss.PlayerInSight())
        {
            canRun = false;
        }

        if(BossHP.currentHealth <= 100 && BossHP.currentHealth >= 1)
        {
            canRun = false;
            Vector2 target = new Vector2(EnRagePlace.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
