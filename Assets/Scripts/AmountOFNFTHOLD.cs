using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountOFNFTHOLD : MonoBehaviour
{
    public static int amountOfFirstKrazyKongNFt;

    public int AmountofCheckKrazyKongHoldAmount;

    private void Awake()
    {
        amountOfFirstKrazyKongNFt = PlayerPrefs.GetInt("amountOfFirstKrazyKongNFt", 0);
    }
    private void Update()
    {
        AmountofCheckKrazyKongHoldAmount = amountOfFirstKrazyKongNFt;
    }
}
