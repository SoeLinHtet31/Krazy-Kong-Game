using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2SamuraiIdle : StateMachineBehaviour
{
    Stage2MeleeEnemy meleeEnemy;
    Transform stittingPlace;
    Transform player;
    Rigidbody2D rb;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stittingPlace = GameObject.FindGameObjectWithTag("Sitting Place").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        meleeEnemy = animator.GetComponent<Stage2MeleeEnemy>();
        rb = animator.GetComponent<Rigidbody2D>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }


}
