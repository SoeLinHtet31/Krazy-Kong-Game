using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    public static int numberOfCoin;
    public TextMeshProUGUI coinText;

    public void Awake()
    {
        numberOfCoin = PlayerPrefs.GetInt("NumberOfCoin", 0);
    }

    public void Update()
    {
        coinText.text = numberOfCoin.ToString();
        if (numberOfCoin < 0)
        {
            coinText.text = "0";
        }
    }
}
