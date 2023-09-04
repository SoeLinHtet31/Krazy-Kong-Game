using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava31 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x2f58a219ab53e6292ea2dbf4fb993b7f17a8ea4e";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT31Main.NFt31Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT31Main.NFt31Amount += 1;
            PlayerPrefs.SetInt("NFt31Amount", NFT31Main.NFt31Amount);

            SKYBITToken.SkyBitTokengainAmount += 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT31Main.NFt31Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT31Main.NFt31Amount -= 1;
            PlayerPrefs.SetInt("NFt31Amount", NFT31Main.NFt31Amount);

            SKYBITToken.SkyBitTokengainAmount -= 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
