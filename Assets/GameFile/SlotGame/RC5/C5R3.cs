using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5R3 : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;

    public string stoppedPrize;

    public GameObject GameTrigger;
    public GameObject PrizeResult;

    public GameObject BetButtom;
    public GameObject BetButtonIdle;

    [SerializeField] public NGC5R3 number;

    private void Update()
    {
        if(SKYBITToken.SkybitToken >= 100 &&  rowStopped)
        {
            BetButtom.SetActive(true);
            BetButtonIdle.SetActive(false);
        }
        else if(SKYBITToken.SkybitToken <= 99 || !rowStopped)
        {
            BetButtom.SetActive(false);
            BetButtonIdle.SetActive(true);
        }
    }


    void Start()
    {
        rowStopped = true;
        GameSlotTrigger.HandlePulled += StartRotationg;
        PrizeResult.SetActive(false);
    }

    private void StartRotationg()
    {

        PrizeResult.SetActive(false);
        BetButtom.SetActive(false);
        BetButtonIdle.SetActive(true);
        stoppedSlot = "";
        stoppedPrize = "";
        StartCoroutine("Rotate");
        SKYBITToken.SkybitToken -= 100;
        PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -6.85f)
                transform.position = new Vector2(transform.position.x, -1.6f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);

        }

        randomValue = Random.Range(170, 180);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 2;
                break;
            case 2:
                randomValue += 1;
                break;
        }

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -6.85f)
                transform.position = new Vector2(transform.position.x, -1.6f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f;


            yield return new WaitForSeconds(timeInterval);

        }

        //Cherry
        if (number.stoppedSlot == "1")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "5")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "10")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "15")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "20")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "25")
            transform.position = new Vector2(transform.position.x, -1.6f);
        if (number.stoppedSlot == "30")
            transform.position = new Vector2(transform.position.x, -1.6f);


        //Mango
        if (number.stoppedSlot == "2")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "6")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "11")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "16")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "19")
            transform.position = new Vector2(transform.position.x, -6.1f);

        //WaterMelon
        if (number.stoppedSlot == "3")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "7")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "12")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "17")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "24")
            transform.position = new Vector2(transform.position.x, -5.35f);


        //Diamond
        if (number.stoppedSlot == "4")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "8")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "13")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "18")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "29")
            transform.position = new Vector2(transform.position.x, -4.6f);

        //Micheal Kong
        if (number.stoppedSlot == "21")
            transform.position = new Vector2(transform.position.x, -3.85f);
        if (number.stoppedSlot == "22")
            transform.position = new Vector2(transform.position.x, -3.85f);
        if (number.stoppedSlot == "23")
            transform.position = new Vector2(transform.position.x, -3.85f);


        //Prisoner Kong
        if (number.stoppedSlot == "26")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "27")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "28")
            transform.position = new Vector2(transform.position.x, -3.1f);


        //King Kong
        if (number.stoppedSlot == "31")
            transform.position = new Vector2(transform.position.x, -2.35f);
        if (number.stoppedSlot == "32")
            transform.position = new Vector2(transform.position.x, -2.35f);

        if (transform.position.y == -1.6f)
            stoppedSlot = "Cherry";
        else if (transform.position.y == -6.1f)
            stoppedSlot = "Mango";
        else if (transform.position.y == -5.35f)
            stoppedSlot = "WaterMelon";
        else if (transform.position.y == -4.6f)
            stoppedSlot = "Diamond";
        else if (transform.position.y == -3.85f)
            stoppedSlot = "MichealKong";
        else if (transform.position.y == -3.1f)
            stoppedSlot = "PrisonerKong";
        else if (transform.position.y == -2.35f)
            stoppedSlot = "KingKong";
        else if (transform.position.y == -6.85f)
            stoppedSlot = "Cherry";

        if (transform.position.y == -1.6f)
            stoppedPrize = "C";
        else if (transform.position.y == -6.1f)
            stoppedPrize = "M";
        else if (transform.position.y == -5.35f)
            stoppedPrize = "W";
        else if (transform.position.y == -4.6f)
            stoppedPrize = "D";
        else if (transform.position.y == -3.85f)
            stoppedPrize = "Mic";
        else if (transform.position.y == -3.1f)
            stoppedPrize = "Pri";
        else if (transform.position.y == -2.35f)
            stoppedPrize = "King";
        else if (transform.position.y == -6.85f)
            stoppedPrize = "C";



        PrizeResult.SetActive(true);
        BetButtom.SetActive(true);
        BetButtonIdle.SetActive(false);
        rowStopped = true;

    }
    private void OnDestroy()
    {
        GameSlotTrigger.HandlePulled -= StartRotationg;
    }
}
