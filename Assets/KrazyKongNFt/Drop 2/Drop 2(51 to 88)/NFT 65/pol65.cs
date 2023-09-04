using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol65 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xae4c35941fcdf965725c157728763a1b76ce349e";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT65Main.NFt65Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT65Main.NFt65Amount += 1;
            PlayerPrefs.SetInt("NFt65Amount", NFT65Main.NFt65Amount);

            SKYBITToken.SkyBitTokengainAmount += 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT65Main.NFt65Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT65Main.NFt65Amount -= 1;
            PlayerPrefs.SetInt("NFt65Amount", NFT65Main.NFt65Amount);

            SKYBITToken.SkyBitTokengainAmount -= 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
