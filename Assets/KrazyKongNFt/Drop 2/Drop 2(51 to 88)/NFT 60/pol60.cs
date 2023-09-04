using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol60 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x978bad302e50f8a79645707b688bae5d6b110dec";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT60Main.NFt60Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT60Main.NFt60Amount += 1;
            PlayerPrefs.SetInt("NFt60Amount", NFT60Main.NFt60Amount);

            SKYBITToken.SkyBitTokengainAmount += 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT60Main.NFt60Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT60Main.NFt60Amount -= 1;
            PlayerPrefs.SetInt("NFt60Amount", NFT60Main.NFt60Amount);

            SKYBITToken.SkyBitTokengainAmount -= 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
