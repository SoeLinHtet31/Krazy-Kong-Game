using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class poly5 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x060c549b46d97c4b0bf116544ec9a304dd4b1c07";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT5Main.NFt5Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT5Main.NFt5Amount += 1;
            PlayerPrefs.SetInt("NFt5Amount", NFT5Main.NFt5Amount);

            SKYBITToken.SkyBitTokengainAmount += 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT5Main.NFt5Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT5Main.NFt5Amount -= 1;
            PlayerPrefs.SetInt("NFt5Amount", NFT5Main.NFt5Amount);

            SKYBITToken.SkyBitTokengainAmount -= 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
