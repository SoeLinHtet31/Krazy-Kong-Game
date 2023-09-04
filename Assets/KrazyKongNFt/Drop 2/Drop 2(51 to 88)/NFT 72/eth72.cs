using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;


public class eth72 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xc4883d4df9213ebdaae429a9d812bee2511fc23c";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT72Main.NFt72Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT72Main.NFt72Amount += 1;
            PlayerPrefs.SetInt("NFt72Amount", NFT72Main.NFt72Amount);

            SKYBITToken.SkyBitTokengainAmount += 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT72Main.NFt72Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT72Main.NFt72Amount -= 1;
            PlayerPrefs.SetInt("NFt72Amount", NFT72Main.NFt72Amount);

            SKYBITToken.SkyBitTokengainAmount -= 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }

    }
}
