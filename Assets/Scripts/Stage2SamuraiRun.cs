using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2SamuraiRun : StateMachineBehaviour
{
    public float speed = 15f;
    Stage2MeleeEnemy meleeEnemy;
    Transform stittingPlace;
    Transform player;
    Rigidbody2D rb;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stittingPlace = GameObject.Find("Chair9").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        meleeEnemy = animator.GetComponent<Stage2MeleeEnemy>();
        rb = GameObject.Find("").GetComponent<Rigidbody2D>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (meleeEnemy.goToIdlePlace)
        {
            meleeEnemy.TurnBack();
            Vector2 target = new Vector2(stittingPlace.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }
        else if (meleeEnemy.canMove)
        {
            meleeEnemy.LookAtThePlayer();
            Vector2 target = new Vector2(player.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
