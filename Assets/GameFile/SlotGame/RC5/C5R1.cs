using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5R1 : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;

    public string stoppedPrize;

    [SerializeField] public NGC5R1 number;



 
    void Start()
    {

        rowStopped = true;
        GameSlotTrigger.HandlePulled += StartRotationg;
    }

    private void StartRotationg()
    {
 
        stoppedSlot = "";
        stoppedPrize = "";
        StartCoroutine("Rotate");
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;


        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -8.35f)
                transform.position = new Vector2(transform.position.x, -3.1f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);

        }

        randomValue = Random.Range(150, 160);

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
            if (transform.position.y <= -8.35f)
                transform.position = new Vector2(transform.position.x, -3.1f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f;


            yield return new WaitForSeconds(timeInterval);

        }

        //Cherry
        if (number.stoppedSlot == "1")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "5")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "10")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "15")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "20")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "25")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "30")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "2")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "6")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "11")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "16")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "21")
            transform.position = new Vector2(transform.position.x, -3.1f);
        if (number.stoppedSlot == "26")
            transform.position = new Vector2(transform.position.x, -3.1f);

        //Mango
        if (number.stoppedSlot == "2")
            transform.position = new Vector2(transform.position.x, -7.6f);
        if (number.stoppedSlot == "6")
            transform.position = new Vector2(transform.position.x, -7.6f);
        if (number.stoppedSlot == "11")
            transform.position = new Vector2(transform.position.x, -7.6f);
        if (number.stoppedSlot == "16")
            transform.position = new Vector2(transform.position.x, -7.6f);
        if (number.stoppedSlot == "19")
            transform.position = new Vector2(transform.position.x, -7.6f);

        //WaterMelon
        if (number.stoppedSlot == "3")
            transform.position = new Vector2(transform.position.x, -6.85f);
        if (number.stoppedSlot == "7")
            transform.position = new Vector2(transform.position.x, -6.85f);
        if (number.stoppedSlot == "12")
            transform.position = new Vector2(transform.position.x, -6.85f);
        if (number.stoppedSlot == "17")
            transform.position = new Vector2(transform.position.x, -6.85f);
        if (number.stoppedSlot == "24")
            transform.position = new Vector2(transform.position.x, -6.85f);


        //Diamond
        if (number.stoppedSlot == "4")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "8")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "13")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "18")
            transform.position = new Vector2(transform.position.x, -6.1f);
        if (number.stoppedSlot == "29")
            transform.position = new Vector2(transform.position.x, -6.1f);

        //Micheal Kong
        if (number.stoppedSlot == "21")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "22")
            transform.position = new Vector2(transform.position.x, -5.35f);
        if (number.stoppedSlot == "23")
            transform.position = new Vector2(transform.position.x, -5.35f);


        //Prisoner Kong
        if (number.stoppedSlot == "26")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "27")
            transform.position = new Vector2(transform.position.x, -4.6f);
        if (number.stoppedSlot == "28")
            transform.position = new Vector2(transform.position.x, -4.6f);


        //King Kong
        if (number.stoppedSlot == "31")
            transform.position = new Vector2(transform.position.x, -3.85f);
        if (number.stoppedSlot == "32")
            transform.position = new Vector2(transform.position.x, -3.85f);

        if (transform.position.y == -3.1f)
            stoppedSlot = "Cherry";
        else if (transform.position.y == -7.6f)
            stoppedSlot = "Mango";
        else if (transform.position.y == -6.85f)
            stoppedSlot = "WaterMelon";
        else if (transform.position.y == -6.1f)
            stoppedSlot = "Diamond";
        else if (transform.position.y == -5.35f)
            stoppedSlot = "MichealKong";
        else if (transform.position.y == -4.6f)
            stoppedSlot = "PrisonerKong";
        else if (transform.position.y == -3.85f)
            stoppedSlot = "KingKong";
        else if (transform.position.y == -8.35f)
            stoppedSlot = "Cherry";

        if (transform.position.y == -3.1f)
            stoppedPrize = "C";
        else if (transform.position.y == -7.6f)
            stoppedPrize = "M";
        else if (transform.position.y == -6.85f)
            stoppedPrize = "W";
        else if (transform.position.y == -6.1f)
            stoppedPrize = "D";
        else if (transform.position.y == -5.35f)
            stoppedPrize = "Mic";
        else if (transform.position.y == -4.6f)
            stoppedPrize = "Pri";
        else if (transform.position.y == -3.85f)
            stoppedPrize = "King";
        else if (transform.position.y == -8.35f)
            stoppedPrize = "C";




        rowStopped = true;

    }
    private void OnDestroy()
    {
        GameSlotTrigger.HandlePulled -= StartRotationg;
    }

}
