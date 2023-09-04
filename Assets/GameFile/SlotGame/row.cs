using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class row : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;

    void Start()
    {
        rowStopped = true;
        GameSystem.HandlePulled += StartRotationg;
    }

    private void StartRotationg()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -3.5f)
                transform.position = new Vector2(transform.position.x, 1.75f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);

        }

        randomValue = Random.Range(60, 100);

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
            if (transform.position.y <= -3.5f)
                transform.position = new Vector2(transform.position.x, 1.75f);
            
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
        if (transform.position.y == -3.5f)
            stoppedSlot = "Cherry";
        else if (transform.position.y == -2.75f)
            stoppedSlot = "Mango";
        else if (transform.position.y == -2f)
            stoppedSlot = "WaterMelon";
        else if (transform.position.y == -1.25f)
            stoppedSlot = "Diamond";
        else if (transform.position.y == -0.5f)
            stoppedSlot = "MichealKong";
        else if (transform.position.y == 0.25f)
            stoppedSlot = "PrisonerKong";
        else if (transform.position.y == 1f)
            stoppedSlot = "KingKong";
        else if (transform.position.y == 1.75f)
            stoppedSlot = "Cherry";

        rowStopped = true;

    }
    private void OnDestroy()
    {
        GameSystem.HandlePulled -= StartRotationg;
    }
}
