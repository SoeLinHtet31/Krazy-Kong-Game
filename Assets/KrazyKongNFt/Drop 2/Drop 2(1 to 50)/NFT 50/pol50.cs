using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol50 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x6aae6aac05e493cdef30760eb888cb507af9a95d";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT50Main.NFt50Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT50Main.NFt50Amount += 1;
            PlayerPrefs.SetInt("NFt50Amount", NFT50Main.NFt50Amount);

            SKYBITToken.SkyBitTokengainAmount += 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT50Main.NFt50Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT50Main.NFt50Amount -= 1;
            PlayerPrefs.SetInt("NFt50Amount", NFT50Main.NFt50Amount);

            SKYBITToken.SkyBitTokengainAmount -= 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
