using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol17 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x1a7f19c56d8cebee9a611b6990136c098beca735";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT17Main.NFt17Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT17Main.NFt17Amount += 1;
            PlayerPrefs.SetInt("NFt17Amount", NFT17Main.NFt17Amount);

            SKYBITToken.SkyBitTokengainAmount += 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT17Main.NFt17Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT17Main.NFt17Amount -= 1;
            PlayerPrefs.SetInt("NFt17Amount", NFT17Main.NFt17Amount);

            SKYBITToken.SkyBitTokengainAmount -= 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
