using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtomToPause : MonoBehaviour
{
    public GameObject Setting;
    public Canvas cavs;
    public GameObject PayLines;
    public GameObject PrizeSet;


    public void pauseButtom()
    {
        cavs.sortingLayerName = "PlayerRange";
        Setting.SetActive(true);
        Time.timeScale = 0f;
    }

    public void transferToPayline()
    {
        PayLines.SetActive(true);
        PrizeSet.SetActive(false);
        Time.timeScale = 0f;
    }

    public void resumeE()
    {
        cavs.sortingLayerName = "ForeGround";
        PrizeSet.SetActive(false);
        Time.timeScale = 1f;
    }

    public void backFromThePayLine()
    {
        PayLines.SetActive(false);
        PrizeSet.SetActive(true);
        Time.timeScale = 0f;
    }
}
