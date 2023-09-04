using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGC2R2 : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;

    void Start()
    {
        rowStopped = true;
        GameSlotTrigger.HandlePulled += StartRotationg;
    }

    private void StartRotationg()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.0025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -16.75f)
                transform.position = new Vector2(transform.position.x, 6.5f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);

        }

        randomValue = Random.Range(70, 80);

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
            if (transform.position.y <= -16.75f)
                transform.position = new Vector2(transform.position.x, 6.5f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f;

            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.1f;

            if (i > Mathf.RoundToInt(randomValue * 0.75f))
                timeInterval = 0.15f;

            if (i > Mathf.RoundToInt(randomValue * 1f))
                timeInterval = 0.2f;

            yield return new WaitForSeconds(timeInterval);
        }




        if (transform.position.y == 6.50f)
            stoppedSlot = "1";
        if (transform.position.y == 5.75f)
            stoppedSlot = "2";
        else if (transform.position.y == 5f)
            stoppedSlot = "3";
        else if (transform.position.y == 4.25f)
            stoppedSlot = "4";
        else if (transform.position.y == 3.5f)
            stoppedSlot = "5";
        else if (transform.position.y == 2.75f)
            stoppedSlot = "6";
        else if (transform.position.y == 2f)
            stoppedSlot = "7";
        else if (transform.position.y == 1.25f)
            stoppedSlot = "8";
        else if (transform.position.y == 0.50f)
            stoppedSlot = "9";
        else if (transform.position.y == -0.25f)
            stoppedSlot = "10";
        else if (transform.position.y == -1f)
            stoppedSlot = "11";
        else if (transform.position.y == -1.75f)
            stoppedSlot = "12";
        else if (transform.position.y == -2.50f)
            stoppedSlot = "13";
        else if (transform.position.y == -3.25f)
            stoppedSlot = "14";
        else if (transform.position.y == -4f)
            stoppedSlot = "15";
        else if (transform.position.y == -4.75f)
            stoppedSlot = "16";
        else if (transform.position.y == -5.50f)
            stoppedSlot = "17";
        else if (transform.position.y == -6.25f)
            stoppedSlot = "18";
        else if (transform.position.y == -7f)
            stoppedSlot = "19";
        else if (transform.position.y == -7.75f)
            stoppedSlot = "20";
        else if (transform.position.y == -8.50f)
            stoppedSlot = "21";
        else if (transform.position.y == -9.25f)
            stoppedSlot = "22";
        else if (transform.position.y == -10f)
            stoppedSlot = "23";
        else if (transform.position.y == -10.75f)
            stoppedSlot = "24";
        else if (transform.position.y == -11.5f)
            stoppedSlot = "25";
        else if (transform.position.y == -12.25f)
            stoppedSlot = "26";
        else if (transform.position.y == -13f)
            stoppedSlot = "27";
        else if (transform.position.y == -13.75f)
            stoppedSlot = "28";
        else if (transform.position.y == -14.5f)
            stoppedSlot = "29";
        else if (transform.position.y == -15.25f)
            stoppedSlot = "30";
        else if (transform.position.y == -16f)
            stoppedSlot = "31";
        else if (transform.position.y == -16.75f)
            stoppedSlot = "32";


        rowStopped = true;

    }
    private void OnDestroy()
    {
        GameSlotTrigger.HandlePulled -= StartRotationg;
    }
}
