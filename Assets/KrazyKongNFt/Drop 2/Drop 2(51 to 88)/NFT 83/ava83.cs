using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava83 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xdf253987fdb1e82b14a05d9fdb7a058435b3a881";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT83Main.NFt83Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT83Main.NFt83Amount += 1;
            PlayerPrefs.SetInt("NFt83Amount", NFT83Main.NFt83Amount);

            SKYBITToken.SkyBitTokengainAmount += 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT83Main.NFt83Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT83Main.NFt83Amount -= 1;
            PlayerPrefs.SetInt("NFt83Amount", NFT83Main.NFt83Amount);

            SKYBITToken.SkyBitTokengainAmount -= 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
