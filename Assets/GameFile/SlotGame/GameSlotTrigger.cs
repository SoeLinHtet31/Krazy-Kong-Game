using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class GameSlotTrigger : MonoBehaviour
{
   

    public static event Action HandlePulled = delegate { };

    [SerializeField] private TextMeshProUGUI prizeText;

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

    // SKYBTI 100
    public GameObject SKYBIT100;

    public GameObject SKYBIT100two1;
    public GameObject SKYBIT100two2;

    public GameObject SKYBIT100three1;
    public GameObject SKYBIT100three2;
    public GameObject SKYBIT100three3;

    public GameObject SKYBIT100four1;
    public GameObject SKYBIT100four2;
    public GameObject SKYBIT100four3;
    public GameObject SKYBIT100four4;

    public GameObject SKYBIT100five1;
    public GameObject SKYBIT100five2;
    public GameObject SKYBIT100five3;
    public GameObject SKYBIT100five4;
    public GameObject SKYBIT100five5;

    public GameObject SKYBIT100Six1;
    public GameObject SKYBIT100Six2;
    public GameObject SKYBIT100Six3;
    public GameObject SKYBIT100Six4;
    public GameObject SKYBIT100Six5;
    public GameObject SKYBIT100Six6;

    public GameObject SKYBIT100Seven1;
    public GameObject SKYBIT100Seven2;
    public GameObject SKYBIT100Seven3;
    public GameObject SKYBIT100Seven4;
    public GameObject SKYBIT100Seven5;
    public GameObject SKYBIT100Seven6;
    public GameObject SKYBIT100Seven7;


    //SKYBIT 200

    public GameObject SKYBIT2001;

    public GameObject SKYBIT2002;
    public GameObject SKYBIT20021;

    public GameObject SKYBIT20031;
    public GameObject SKYBIT20032;
    public GameObject SKYBIT20033;

    public GameObject SKYBIT20041;
    public GameObject SKYBIT20042;
    public GameObject SKYBIT20043;
    public GameObject SKYBIT20044;


    public GameObject SKYBIT20051;
    public GameObject SKYBIT20052;
    public GameObject SKYBIT20053;
    public GameObject SKYBIT20054;
    public GameObject SKYBIT20055;


    public GameObject SKYBIT20061;
    public GameObject SKYBIT20062;
    public GameObject SKYBIT20063;
    public GameObject SKYBIT20064;
    public GameObject SKYBIT20065;
    public GameObject SKYBIT20066;


    public GameObject SKYBIT20071;
    public GameObject SKYBIT20072;
    public GameObject SKYBIT20073;
    public GameObject SKYBIT20074;
    public GameObject SKYBIT20075;
    public GameObject SKYBIT20076;
    public GameObject SKYBIT20077;

    //SKYBIT 500

    public GameObject SKYBIT5001;

    public GameObject SKYBIT50021;
    public GameObject SKYBIT50022;

    public GameObject SKYBIT50031;
    public GameObject SKYBIT50032;
    public GameObject SKYBIT50033;

    public GameObject SKYBIT50041;
    public GameObject SKYBIT50042;
    public GameObject SKYBIT50043;
    public GameObject SKYBIT50044;


    public GameObject SKYBIT50051;
    public GameObject SKYBIT50052;
    public GameObject SKYBIT50053;
    public GameObject SKYBIT50054;
    public GameObject SKYBIT50055;


    public GameObject SKYBIT50061;
    public GameObject SKYBIT50062;
    public GameObject SKYBIT50063;
    public GameObject SKYBIT50064;
    public GameObject SKYBIT50065;
    public GameObject SKYBIT50066;


    public GameObject SKYBIT50071;
    public GameObject SKYBIT50072;
    public GameObject SKYBIT50073;
    public GameObject SKYBIT50074;
    public GameObject SKYBIT50075;
    public GameObject SKYBIT50076;
    public GameObject SKYBIT50077;


    [SerializeField] private Transform Handle;

    private int prizeValue;
    private int prizeValue2;
    private int prizeValue3;
    private int prizeValue4;
    private int prizeValue5;
    private int prizeValue6;
    private int prizeValue7;

    public bool resultsChecked = false;


    // Update is called once per frame
    void Update()
    {

        prizeText.text = "" + (prizeValue+prizeValue2+prizeValue3+prizeValue4+prizeValue5+prizeValue6+prizeValue7);

        if (!rowC1R1.rowStopped || !rowC1R2.rowStopped || !rowC1R3.rowStopped || !rowC2R1.rowStopped || !rowC2R2.rowStopped || !rowC2R3.rowStopped || !rowC3R1.rowStopped || !rowC3R2.rowStopped || !rowC3R3.rowStopped || !rowC4R1.rowStopped || !rowC4R2.rowStopped || rowC4R3.rowStopped || !rowC5R1.rowStopped || !rowC5R2.rowStopped || !rowC5R3.rowStopped )
        {
            prizeText.enabled = false;
            prizeValue = 0;
            prizeValue2 = 0;
            prizeValue3 = 0;
            prizeValue4 = 0;
            prizeValue5 = 0;
            prizeValue6 = 0;
            prizeValue7 = 0;

            resultsChecked = false;
            
        }

        if (rowC1R1.rowStopped && rowC1R2.rowStopped && rowC1R3.rowStopped && rowC2R1.rowStopped && rowC2R2.rowStopped && rowC2R3.rowStopped && rowC3R1.rowStopped && rowC3R2.rowStopped && rowC3R3.rowStopped && rowC4R1.rowStopped && rowC4R2.rowStopped && rowC4R3.rowStopped && rowC5R1.rowStopped && rowC5R2.rowStopped && rowC5R3.rowStopped)
        {
            prizeText.enabled = true;
            CheckResults();
            ShowPrize();
        }
    }

    public void OnMouseDown()
    {
        if (rowC1R1.rowStopped && rowC1R2.rowStopped && rowC1R3.rowStopped && rowC2R1.rowStopped && rowC2R2.rowStopped && rowC2R3.rowStopped && rowC3R1.rowStopped && rowC3R2.rowStopped && rowC3R3.rowStopped && rowC4R1.rowStopped && rowC4R2.rowStopped && rowC4R3.rowStopped && rowC5R1.rowStopped && rowC5R2.rowStopped && rowC5R3.rowStopped)
            StartCoroutine("PullHandle");
    }

    public IEnumerator PullHandle()
    {
        for (int i = 0; i < 15; i += 5)
        {
            
            Handle.Rotate(0f, 0f, i);
            yield return new WaitForSeconds(0.1f);
        }

        HandlePulled();

        for (int i = 0; i < 15; i += 5)
        {


            Handle.Rotate(0f, 0f, -i);
            yield return new WaitForSeconds(0.1f);
        }

    }

    public void CheckResults()
    {
        //Cherry 3 Pay Line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry"))||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot)  && (rowC3R2.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry")||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry"))||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC1R1.stoppedSlot== rowC1R2.stoppedSlot)&& (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry")||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "Cherry") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "Cherry")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "Cherry")))
            SKYBIT100.SetActive(true);



        //Cherry 4 Pay Line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) &&(rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry"))
            )
        {
            SKYBIT2001.SetActive(true);
        }
           
        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "Cherry") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "Cherry")))
        {
            SKYBIT2001.SetActive(true);
        }


        //Cherry 5 pay line

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }
        
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "Cherry"))
        {
            SKYBIT5001.SetActive(true);
        }

        //Mango 3
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }



        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }


        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "Mango") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "Mango")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "Mango")))
        {
            SKYBIT100two1.SetActive(true);
            SKYBIT100two2.SetActive(true);
        }


        //Mango 4 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango"))
            )
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "Mango") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "Mango")))
        {
            SKYBIT2002.SetActive(true);
            SKYBIT20021.SetActive(true);
        }

        //Mango 5 Pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "Mango"))
        {
            SKYBIT50021.SetActive(true);
            SKYBIT50022.SetActive(true);
        }

        //WaterMelon 3

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }
        

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "WaterMelon") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "WaterMelon")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT100three1.SetActive(true);
            SKYBIT100three2.SetActive(true);
            SKYBIT100three3.SetActive(true);
        }


        //Water Melon 4 pay line 

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon"))
            )
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "WaterMelon") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "WaterMelon")))
        {
            SKYBIT20031.SetActive(true);
            SKYBIT20032.SetActive(true);
            SKYBIT20033.SetActive(true);
        }

        //Water melon 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "WaterMelon"))
        {
            SKYBIT50031.SetActive(true);
            SKYBIT50032.SetActive(true);
            SKYBIT50033.SetActive(true);
        }


        //Diamond 3

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }

        

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }


        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "Diamond") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "Diamond")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "Diamond")))
        {
            SKYBIT100four1.SetActive(true);
            SKYBIT100four2.SetActive(true);
            SKYBIT100four3.SetActive(true);
            SKYBIT100four4.SetActive(true);
        }


        //Diamond 4th Pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond"))
            )
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "Diamond") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "Diamond")))
        {
            SKYBIT20041.SetActive(true);
            SKYBIT20042.SetActive(true);
            SKYBIT20043.SetActive(true);
            SKYBIT20044.SetActive(true);
        }

        //Diamond 5 Pay line
        //Water melon 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "Diamond"))
        {
            SKYBIT50041.SetActive(true);
            SKYBIT50042.SetActive(true);
            SKYBIT50043.SetActive(true);
            SKYBIT50044.SetActive(true);
        }

        //Micheal Kong 3

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }



        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }


        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "MichealKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "MichealKong")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT100five1.SetActive(true);
            SKYBIT100five2.SetActive(true);
            SKYBIT100five3.SetActive(true);
            SKYBIT100five4.SetActive(true);
            SKYBIT100five5.SetActive(true);
        }


        //Micheal Kong 4th pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong"))
            )
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "MichealKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "MichealKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        //Micheal Kong 5 Pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "MichealKong"))
        {
            SKYBIT50051.SetActive(true);
            SKYBIT50052.SetActive(true);
            SKYBIT50053.SetActive(true);
            SKYBIT50054.SetActive(true);
            SKYBIT50055.SetActive(true);
        }
        

        //Prisoner Kong 3

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }



        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }


        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "PrisonerKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "PrisonerKong")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT100Six1.SetActive(true);
            SKYBIT100Six2.SetActive(true);
            SKYBIT100Six3.SetActive(true);
            SKYBIT100Six4.SetActive(true);
            SKYBIT100Six5.SetActive(true);
            SKYBIT100Six6.SetActive(true);
        }


        //Prisoner Kong 4th Pay Line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong"))
            )
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20051.SetActive(true);
            SKYBIT20052.SetActive(true);
            SKYBIT20053.SetActive(true);
            SKYBIT20054.SetActive(true);
            SKYBIT20055.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "PrisonerKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "PrisonerKong")))
        {
            SKYBIT20061.SetActive(true);
            SKYBIT20062.SetActive(true);
            SKYBIT20063.SetActive(true);
            SKYBIT20064.SetActive(true);
            SKYBIT20065.SetActive(true);
            SKYBIT20066.SetActive(true);
        }

        //Prisoner Kong 5 Pay Line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }
        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "PrisonerKong"))
        {
            SKYBIT50061.SetActive(true);
            SKYBIT50062.SetActive(true);
            SKYBIT50063.SetActive(true);
            SKYBIT50064.SetActive(true);
            SKYBIT50065.SetActive(true);
            SKYBIT50066.SetActive(true);
        }


        //King Kong 3

        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R1.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }



        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R3.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }


        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")) ||
            ((rowC3R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R3.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }


        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")) ||
            ((rowC3R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC3R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R1.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R3.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong")) ||
            ((rowC3R2.stoppedSlot == rowC4R1.stoppedSlot) && (rowC3R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC3R2.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong")) ||
            ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == "KingKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == "KingKong")) ||
            ((rowC5R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R3.stoppedSlot == "KingKong")))
        {
            SKYBIT100Seven1.SetActive(true);
            SKYBIT100Seven2.SetActive(true);
            SKYBIT100Seven3.SetActive(true);
            SKYBIT100Seven4.SetActive(true);
            SKYBIT100Seven5.SetActive(true);
            SKYBIT100Seven6.SetActive(true);
            SKYBIT100Seven7.SetActive(true);
        }


        //King Kong 4th pay line 
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong"))
            )
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }


        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R3.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC2R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC2R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R2.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }
        // new pay line 4
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC2R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC2R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC2R1.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong") ||
            ((rowC2R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC2R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC2R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC2R3.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }
        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong") ||
            ((rowC1R2.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == "KingKong") ||
            ((rowC5R2.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R2.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R2.stoppedSlot == "KingKong")))
        {
            SKYBIT20071.SetActive(true);
            SKYBIT20072.SetActive(true);
            SKYBIT20073.SetActive(true);
            SKYBIT20074.SetActive(true);
            SKYBIT20075.SetActive(true);
            SKYBIT20076.SetActive(true);
            SKYBIT20077.SetActive(true);
        }

        //King Kong 5 pay Line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R2.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R2.stoppedSlot == rowC5R2.stoppedSlot) && (rowC1R2.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }
        //new 5 pay line
        if ((rowC1R1.stoppedSlot == rowC2R1.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC4R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R3.stoppedSlot == rowC2R3.stoppedSlot) && (rowC1R3.stoppedSlot == rowC3R2.stoppedSlot) && (rowC1R3.stoppedSlot == rowC4R1.stoppedSlot) && (rowC1R3.stoppedSlot == rowC5R1.stoppedSlot) && (rowC1R3.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC1R1.stoppedSlot == rowC1R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC1R3.stoppedSlot) && (rowC1R1.stoppedSlot == rowC2R2.stoppedSlot) && (rowC1R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC1R1.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }

        if ((rowC5R1.stoppedSlot == rowC5R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC5R3.stoppedSlot) && (rowC5R1.stoppedSlot == rowC4R2.stoppedSlot) && (rowC5R1.stoppedSlot == rowC3R1.stoppedSlot) && (rowC5R1.stoppedSlot == "KingKong"))
        {
            SKYBIT50071.SetActive(true);
            SKYBIT50072.SetActive(true);
            SKYBIT50073.SetActive(true);
            SKYBIT50074.SetActive(true);
            SKYBIT50075.SetActive(true);
            SKYBIT50076.SetActive(true);
            SKYBIT50077.SetActive(true);
        }


        Invoke("SetFalse", 0.1f);


        resultsChecked = true;

    }

    public void ShowPrize()
    {
        //Cherry 3 

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "C")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "C")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "C")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "C")))
            prizeValue = 100;


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "C")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "C")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "C")))
            prizeValue = 100;
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "C")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "C")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "C")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "C")))
            prizeValue = 100;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "C") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "C")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "C")))
            prizeValue = 100;


        //Cherry 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "C"))
            )
        {
            prizeValue = 200;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "C") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "C") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "C") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "C")))
        {
            prizeValue = 200;
        }

        //Cherry 5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "C"))
        {
            prizeValue = 500;
        }

        //Mango 3
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "M")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "M")))
        {
            prizeValue2 = 200;
        }



        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "M")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "M")))
        {
            prizeValue2 = 200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "M")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "M")))
        {
            prizeValue2 = 200;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "M")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "M")))
        {
            prizeValue2 = 200;
        }


        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "M")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "M")))
        {
            prizeValue2 = 200;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "M")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "M")))
            prizeValue2 = 200;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "M")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "M")))
            prizeValue2 = 200;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "M")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "M")))
            prizeValue2 = 200;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "M") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "M")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "M")))
            prizeValue2 = 200;


        //Mango 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "M"))
            )
        {
            prizeValue2 = 400;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "M") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "M") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "M") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "M")))
        {
            prizeValue2 = 400;
        }


        //MANGO 5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "M"))
        {
            prizeValue2 = 1000;
        }
        //WaterMelon 3

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "W")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "W")))
        {
            prizeValue3 = 300;
        }


        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "W")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "W")))
        {
            prizeValue3 = 300;
        }


        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "W")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "W")))
        {
            prizeValue3 = 300;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "W")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "W")))
        {
            prizeValue3 = 300;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "W")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "W")))
        {
            prizeValue3 = 300;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "W")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "W")))
            prizeValue3 = 300;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "W")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "W")))
            prizeValue3 = 300;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "W")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "W")))
            prizeValue3 = 300;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "W") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "W")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "W")))
            prizeValue3 = 300;


        //wATER mELON 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "W"))
            )
        {
            prizeValue3 = 600;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "W") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "W") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "W") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "W")))
        {
            prizeValue3 = 600;
        }


        //wATER MELON 5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }
        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "W"))
        {
            prizeValue3 = 1500;
        }

        //Diamond 3

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "D")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "D")))
        {
            prizeValue4 = 400;
        }


        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "D")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "D")))
        {
            prizeValue4 = 400;
        }



        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "D")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "D")))
        {
            prizeValue4 = 400;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "D")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "D")))
        {
            prizeValue4 = 400;
        }


        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "D")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "D")))
        {
            prizeValue4 = 400;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "D")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "D")))
            prizeValue4 = 400;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "D")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "D")))
            prizeValue4 = 400;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "D")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "D")))
            prizeValue4 = 400;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "D") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "D")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "D")))
            prizeValue4 = 400;


        //DIAMIND 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "D"))
            )
        {
            prizeValue4 = 800;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "D") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "D") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "D") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "D")))
        {
            prizeValue4 = 800;
        }

        //DIAMOND 5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }
        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "D"))
        {
            prizeValue4 = 2000;
        }


        //Micheal Kong 3

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "Mic")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "Mic")))
        {
            prizeValue5 = 500;
        }


        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 500;
        }



        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "Mic")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "Mic")))
        {
            prizeValue5 = 500;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "Mic")))
        {
            prizeValue5 = 500;
        }
        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "Mic")))
        {
            prizeValue5 = 500;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "Mic")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "Mic")))
            prizeValue5 = 500;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "Mic")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "Mic")))
            prizeValue5 = 500;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Mic")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic")))
            prizeValue5 = 500;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "Mic") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "Mic")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "Mic")))
            prizeValue5 = 500;


        //MICHEAL KONG 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "Mic"))
            )
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "Mic") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "Mic")))
        {
            prizeValue5 = 1000;
        }

        //Micheal 5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }
        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "Mic"))
        {
            prizeValue5 = 2500;
        }

        //Prisoner Kong 3

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "Pri")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "Pri")))
        {
            prizeValue6 = 600;
        }


        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 600;
        }



        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "Pri")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "Pri")))
        {
            prizeValue6 = 600;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "Pri")))
        {
            prizeValue6 = 600;
        }


        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "Pri")))
        {
            prizeValue6 = 600;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "Pri")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "Pri")))
            prizeValue6 = 600;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "Pri")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "Pri")))
            prizeValue6 = 600;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Pri")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri")))
            prizeValue6 = 600;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "Pri") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "Pri")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "Pri")))
            prizeValue6 = 600;

        //Prisoner Kong 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "Pri"))
            )
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "Pri") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "Pri")))
        {
            prizeValue6 = 1200;
        }

        //Prisoner Kong  5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }
        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "Pri"))
        {
            prizeValue6 = 3000;
        }

        //King Kong 3

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == "King")) ||
            ((rowC3R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R1.stoppedPrize == "King")))
        {
            prizeValue7 = 700;
        }


        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "King")) ||
            ((rowC3R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC3R2.stoppedPrize == "King")))
        {
            prizeValue7 = 700;
        }



        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == "King")) ||
            ((rowC3R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R3.stoppedPrize == "King")))
        {
            prizeValue7 = 700;
        }


        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "King")) ||
            ((rowC3R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R3.stoppedPrize == "King")))
        {
            prizeValue7 = 700;
        }


        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == "King")) ||
            ((rowC3R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC3R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R1.stoppedPrize == "King")))
        {
            prizeValue7 = 700;
        }
        // 3 Pay Line New
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == "King")) ||
            ((rowC3R2.stoppedPrize == rowC4R3.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC3R2.stoppedPrize == "King")))
            prizeValue7 = 700;

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == "King")) ||
            ((rowC3R2.stoppedPrize == rowC4R1.stoppedPrize) && (rowC3R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC3R2.stoppedPrize == "King")))
            prizeValue7 = 700;

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == "King")) ||
            ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == "King")))
            prizeValue7 = 700;

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == "King") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == "King")) ||
            ((rowC5R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R3.stoppedPrize == "King")))
            prizeValue7 = 700;

        //King Kong 4 Pay Line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R1.stoppedPrize == "King"))
            )
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC2R2.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R3.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R3.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R2.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC2R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC2R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R2.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }
        // new pay line 4
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC2R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC2R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC2R1.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == "King") ||
            ((rowC2R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC2R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC2R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC2R3.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == "King") ||
            ((rowC1R2.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R2.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == "King") ||
            ((rowC5R2.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R2.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R2.stoppedPrize == "King")))
        {
            prizeValue7 = 1400;
        }

        //King Kong  5 pay line

        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC1R2.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R2.stoppedPrize == rowC5R2.stoppedPrize) && (rowC1R2.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R1.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC1R3.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R3.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }
        //new 5 pay line
        if ((rowC1R1.stoppedPrize == rowC2R1.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC4R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC1R1.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }
        if ((rowC1R3.stoppedPrize == rowC2R3.stoppedPrize) && (rowC1R3.stoppedPrize == rowC3R2.stoppedPrize) && (rowC1R3.stoppedPrize == rowC4R1.stoppedPrize) && (rowC1R3.stoppedPrize == rowC5R1.stoppedPrize) && (rowC1R3.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC1R1.stoppedPrize == rowC1R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC1R3.stoppedPrize) && (rowC1R1.stoppedPrize == rowC2R2.stoppedPrize) && (rowC1R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC1R1.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }

        if ((rowC5R1.stoppedPrize == rowC5R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC5R3.stoppedPrize) && (rowC5R1.stoppedPrize == rowC4R2.stoppedPrize) && (rowC5R1.stoppedPrize == rowC3R1.stoppedPrize) && (rowC5R1.stoppedPrize == "King"))
        {
            prizeValue7 = 3500;
        }
    }
    void SetFalse()

    {
        rowC1R1.stoppedSlot = "";
        rowC1R2.stoppedSlot = "";
        rowC1R3.stoppedSlot = "";
        rowC2R1.stoppedSlot = "";
        rowC2R2.stoppedSlot = "";
        rowC2R3.stoppedSlot = "";
        rowC3R1.stoppedSlot = "";
        rowC3R2.stoppedSlot = "";
        rowC3R3.stoppedSlot = "";
        rowC4R1.stoppedSlot = "";
        rowC4R2.stoppedSlot = "";
        rowC4R3.stoppedSlot = "";
        rowC5R1.stoppedSlot = "";
        rowC5R2.stoppedSlot = "";
        rowC5R3.stoppedSlot = "";
    }
}
