using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol78 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xd516d5de63a7a768418da82f6e7a4d7ab9fbdd83";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT78Main.NFt78Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT78Main.NFt78Amount += 1;
            PlayerPrefs.SetInt("NFt78Amount", NFT78Main.NFt78Amount);

            SKYBITToken.SkyBitTokengainAmount += 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT78Main.NFt78Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT78Main.NFt78Amount -= 1;
            PlayerPrefs.SetInt("NFt78Amount", NFT78Main.NFt78Amount);

            SKYBITToken.SkyBitTokengainAmount -= 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }

    }
}
