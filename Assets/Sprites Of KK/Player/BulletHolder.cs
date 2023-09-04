using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHolder : MonoBehaviour
{
    public Transform Player;

    private Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Player.transform.localScale.x == 1)
        {
            anim.SetTrigger("TurnLeft");
        }

        if (Player.transform.localScale.x == -1)
        {
            anim.SetTrigger("TurnRight");
        }
    }


}
