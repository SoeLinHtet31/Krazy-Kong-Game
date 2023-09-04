using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class eth77 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xd4f5d3590483ea0c1ac82b4e44c36696203d3cf6";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT77Main.NFt77Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT77Main.NFt77Amount += 1;
            PlayerPrefs.SetInt("NFt77Amount", NFT77Main.NFt77Amount);

            SKYBITToken.SkyBitTokengainAmount += 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT77Main.NFt77Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT77Main.NFt77Amount -= 1;
            PlayerPrefs.SetInt("NFt77Amount", NFT77Main.NFt77Amount);

            SKYBITToken.SkyBitTokengainAmount -= 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }

    }
}
