using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol28 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x2eab7ede7ad7ae46f7759fa486f8a4026e3c50d3";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT28Main.NFt28Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT28Main.NFt28Amount += 1;
            PlayerPrefs.SetInt("NFt28Amount", NFT28Main.NFt28Amount);

            SKYBITToken.SkyBitTokengainAmount += 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT28Main.NFt28Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT28Main.NFt28Amount -= 1;
            PlayerPrefs.SetInt("NFt28Amount", NFT28Main.NFt28Amount);

            SKYBITToken.SkyBitTokengainAmount -= 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
