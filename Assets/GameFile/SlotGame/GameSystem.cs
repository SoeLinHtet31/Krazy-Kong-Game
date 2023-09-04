using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class GameSystem : MonoBehaviour
{
    public static event Action HandlePulled = delegate { };

    [SerializeField] private TextMeshProUGUI prizeText;

    [SerializeField] private row[] rows;



    [SerializeField] private Transform Handle;

    private int prizeValue;

    public bool resultsChecked = false;

    // Update is called once per frame
    void Update()
    {
        if (!rows[0].rowStopped || !rows[1].rowStopped || !rows[2].rowStopped)
        {
            prizeValue = 0;
            prizeText.enabled = false;
            resultsChecked = false;
        }

        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped)
        {
            CheckResults();
            prizeText.enabled = true;
            prizeText.text = "Prize: "+ prizeValue;
        }
    }

    private void OnMouseDown()
    {
        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped)
            StartCoroutine("PullHandle");
    }

    private IEnumerator PullHandle()
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

    private void CheckResults()
    {

        if (rows[0].stoppedSlot == "Cherry" && rows[1].stoppedSlot == "Cherry" && rows[2].stoppedSlot == "Cherry")
            prizeValue = 10;

        else if (rows[0].stoppedSlot == "Mango" && rows[1].stoppedSlot == "Mango" && rows[2].stoppedSlot == "Mango")
            prizeValue = 20;

        else if (rows[0].stoppedSlot == "WaterMelon" && rows[1].stoppedSlot == "WaterMelon" && rows[2].stoppedSlot == "WaterMelon")
            prizeValue = 30;

        else if (rows[0].stoppedSlot == "Diamond" && rows[1].stoppedSlot == "Diamond" && rows[2].stoppedSlot == "Diamond")
            prizeValue = 40;

        else if (rows[0].stoppedSlot == "MichealKong" && rows[1].stoppedSlot == "MichealKong" && rows[2].stoppedSlot == "MichealKong")
            prizeValue = 50;

        else if (rows[0].stoppedSlot == "PrisonerKong" && rows[1].stoppedSlot == "PrisonerKong" && rows[2].stoppedSlot == "PrisonerKong")
            prizeValue = 60;

        else if (rows[0].stoppedSlot == "KingKong" && rows[1].stoppedSlot == "KingKong" && rows[2].stoppedSlot == "KingKong")
            prizeValue = 70;




        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "Cherry")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "Cherry")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "Cherry")))
            prizeValue = 10;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "Mango")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "Mango")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "Mango")))
            prizeValue = 20;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "WaterMelon")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "WaterMelon")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "WaterMelon")))
            prizeValue = 30;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "Diamond")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "Diamond")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "Diamond")))
            prizeValue = 40;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "MichealKong")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "MichealKong")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "MichealKong")))
            prizeValue = 50;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "PrisonerKong")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "PrisonerKong")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "PrisonerKong")))
            prizeValue = 60;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) && (rows[0].stoppedSlot == "KingKong")) || ((rows[0].stoppedSlot == rows[2].stoppedSlot) && (rows[0].stoppedSlot == "KingKong")) || ((rows[1].stoppedSlot == rows[2].stoppedSlot) && (rows[1].stoppedSlot == "KingKong")))
            prizeValue = 70;

        resultsChecked = true;
    }

}
