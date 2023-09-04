using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SKYBITToken : MonoBehaviour
{
    public static int numberOfToken;
    public static int SkyBitTokengainAmount;
    public static int SkybitToken;

    public int skyBitTokengainAmount;

    public TextMeshProUGUI skybitToken;

    public void Awake()
    {
        numberOfToken = PlayerPrefs.GetInt("NumberOfToken", 0);
        SkybitToken = PlayerPrefs.GetInt("SkybitToken", 0);
        SkyBitTokengainAmount = PlayerPrefs.GetInt("skyBitTokengainAmount", 0);
    }

    public void Update()
    {
        skyBitTokengainAmount = SkyBitTokengainAmount;
        skybitToken.text = SkybitToken.ToString();
        if (SkybitToken <= 0)
        {
            skybitToken.text = "0";
        }
    }
}
