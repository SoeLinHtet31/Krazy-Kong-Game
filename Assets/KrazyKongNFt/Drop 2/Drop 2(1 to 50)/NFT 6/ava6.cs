using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava6 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x066c8eba7a5fb7a6ec0b73119b80252eef7a3b96";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT6Main.NFt6Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT6Main.NFt6Amount += 1;
            PlayerPrefs.SetInt("NFt6Amount", NFT6Main.NFt6Amount);

            SKYBITToken.SkyBitTokengainAmount += 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT6Main.NFt6Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT6Main.NFt6Amount -= 1;
            PlayerPrefs.SetInt("NFt6Amount", NFT6Main.NFt6Amount);

            SKYBITToken.SkyBitTokengainAmount -= 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
