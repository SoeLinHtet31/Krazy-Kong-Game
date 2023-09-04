using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class eth22 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x1ded6f191ef6a4ac31fb70efb12e9df844a5a26c";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT22Main.NFt22Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT22Main.NFt22Amount += 1;
            PlayerPrefs.SetInt("NFt22Amount", NFT22Main.NFt22Amount);

            SKYBITToken.SkyBitTokengainAmount += 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT22Main.NFt22Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT22Main.NFt22Amount -= 1;
            PlayerPrefs.SetInt("NFt22Amount", NFT22Main.NFt22Amount);

            SKYBITToken.SkyBitTokengainAmount -= 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
