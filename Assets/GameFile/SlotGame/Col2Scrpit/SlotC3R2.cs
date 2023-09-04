using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotC3R2 : MonoBehaviour
{
    [SerializeField] private Row1 rowC1R1;
    [SerializeField] private C1R2 rowC1R2;
    [SerializeField] private C1R3 rowC1R3;
    [SerializeField] private C2R1 rowC2R1;
    [SerializeField] private C2R2 rowC2R2;
    [SerializeField] private C2R3 rowC2R3;
    [SerializeField] private C3R1 rowC3R1;
    [SerializeField] private C3R2 rowC3R2;
    [SerializeField] private C3R3 rowC3R3;
    [SerializeField] private C4R1 rowC4R1;
    [SerializeField] private C4R2 rowC4R2;
    [SerializeField] private C4R3 rowC4R3;
    [SerializeField] private C5R1 rowC5R1;
    [SerializeField] private C5R2 rowC5R2;
    [SerializeField] private C5R3 rowC5R3;

    private Animator anim;



    private void Update()
    {
        anim = GetComponent<Animator>();
        if (!rowC1R1.rowStopped && !rowC1R2.rowStopped && !rowC1R3.rowStopped && !rowC2R1.rowStopped && !rowC2R2.rowStopped && !rowC2R3.rowStopped && !rowC3R1.rowStopped && !rowC3R2.rowStopped && !rowC3R3.rowStopped && !rowC4R1.rowStopped && !rowC4R2.rowStopped && !rowC4R3.rowStopped && !rowC5R1.rowStopped && !rowC5R2.rowStopped && !rowC5R3.rowStopped)
        {
            anim.SetTrigger("NotTrigger");
        }

        if (rowC1R1.rowStopped && rowC1R2.rowStopped && rowC1R3.rowStopped && rowC2R1.rowStopped && rowC2R2.rowStopped && rowC2R3.rowStopped && rowC3R1.rowStopped && rowC3R2.rowStopped && rowC3R3.rowStopped && rowC4R1.rowStopped && rowC4R2.rowStopped && rowC4R3.rowStopped && rowC5R1.rowStopped && rowC5R2.rowStopped && rowC5R3.rowStopped)
        {
           
            Setanimation();
        }
    }

    private void Setanimation()
    {
        //Cherry
        
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry") ||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry"))
        {
            anim.SetTrigger("C3R2");
        }

        //Mango
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango")))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango")||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
           (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango"))
        {
            anim.SetTrigger("C3R2");
        }

        //Water Melon
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon") ||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon"))
        {
            anim.SetTrigger("C3R2");
        }

        //Diamond 
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond") ||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond"))
        {
            anim.SetTrigger("C3R2");
        }

        //Micheal Kong
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong") ||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong"))
        {
            anim.SetTrigger("C3R2");
        }

        //PrisonerKong
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
           (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong") ||
            (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
           (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong"))
        {
            anim.SetTrigger("C3R2");
        }

        //King Kong
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            (rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong") ||
            (rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong") ||
           (rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
        if ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong")))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            (rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");

        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong"))
        {
            anim.SetTrigger("C3R2");
        }
    }
}

