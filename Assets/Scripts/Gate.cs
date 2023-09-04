using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        anim.SetTrigger("GateOpen");
    }
    public void CloseDoor()
    {
        anim.SetTrigger("GateClose");
    }
}
