using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class eth32 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x36e621549473c483f9bda97c37b4b1bd3ff8e4c4";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT32Main.NFt32Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT32Main.NFt32Amount += 1;
            PlayerPrefs.SetInt("NFt32Amount", NFT32Main.NFt32Amount);

            SKYBITToken.SkyBitTokengainAmount += 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT32Main.NFt32Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT32Main.NFt32Amount -= 1;
            PlayerPrefs.SetInt("NFt32Amount", NFT32Main.NFt32Amount);

            SKYBITToken.SkyBitTokengainAmount -= 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
