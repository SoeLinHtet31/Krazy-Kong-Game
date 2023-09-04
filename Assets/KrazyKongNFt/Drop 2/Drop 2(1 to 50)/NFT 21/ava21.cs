using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava21 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x1d7cb04a6c2ba926115cd55f82f6c6a163213f8e";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT21Main.NFt21Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT21Main.NFt21Amount += 1;
            PlayerPrefs.SetInt("NFt21Amount", NFT21Main.NFt21Amount);

            SKYBITToken.SkyBitTokengainAmount += 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT21Main.NFt21Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT21Main.NFt21Amount -= 1;
            PlayerPrefs.SetInt("NFt21Amount", NFT21Main.NFt21Amount);

            SKYBITToken.SkyBitTokengainAmount -= 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
