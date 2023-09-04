using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol55 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x75a27e2f2a0ed2e52f625600ddf787f173f3dbad";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT55Main.NFt55Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT55Main.NFt55Amount += 1;
            PlayerPrefs.SetInt("NFt55Amount", NFT55Main.NFt55Amount);

            SKYBITToken.SkyBitTokengainAmount += 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT55Main.NFt55Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT55Main.NFt55Amount -= 1;
            PlayerPrefs.SetInt("NFt55Amount", NFT55Main.NFt55Amount);

            SKYBITToken.SkyBitTokengainAmount -= 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
