using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version2 : MonoBehaviour
{
    public static int version2amount;
    public int Version2amount;

    public GameObject version2;

    public GameObject page1;
    public GameObject page2;

    public GameObject startIntroDialouge;

    private void Awake()
    {
        version2amount = PlayerPrefs.GetInt("version3amount", 0);
    }



    private void Update()
    {
        if (version2amount == 0)
        {
            version2.SetActive(true);
        }
        else if (version2amount < 0)
        {
            version2.SetActive(false);
        }
        Version2amount = version2amount;

        if (dialogue.StartingDialogue < 0)
        {
            startIntroDialouge.SetActive(false);
        }

        else if (dialogue.StartingDialogue == 0)
        {
            startIntroDialouge.SetActive(true);
        }

        else if (dialogue.StartingDialogue > 0)
        {
            startIntroDialouge.SetActive(false);
        }
    }

    public void GotoPage2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void Exit()
    {
        version2.SetActive(false);
        version2amount -= 5;
        PlayerPrefs.SetInt("version3amount", version2amount);
    }
}
