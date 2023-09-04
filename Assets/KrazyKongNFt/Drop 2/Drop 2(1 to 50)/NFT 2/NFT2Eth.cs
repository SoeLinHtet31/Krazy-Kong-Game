using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class NFT2Eth : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x0389d6b4ba634c1dfd1e1c102852d8dc41f91a1b";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFt2Main.NFt2Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFt2Main.NFt2Amount += 1;
            PlayerPrefs.SetInt("NFt2Amount", NFt2Main.NFt2Amount);

            SKYBITToken.SkyBitTokengainAmount += 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFt2Main.NFt2Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFt2Main.NFt2Amount -= 1;
            PlayerPrefs.SetInt("NFt2Amount", NFt2Main.NFt2Amount);

            SKYBITToken.SkyBitTokengainAmount -= 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
