using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class eth49 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x694ef546147e67175c2a03a3f6e8f00c1f47a578";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT49Main.NFt49Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT49Main.NFt49Amount += 1;
            PlayerPrefs.SetInt("NFt49Amount", NFT49Main.NFt49Amount);

            SKYBITToken.SkyBitTokengainAmount += 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT49Main.NFt49Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT49Main.NFt49Amount -= 1;
            PlayerPrefs.SetInt("NFt49Amount", NFT49Main.NFt49Amount);

            SKYBITToken.SkyBitTokengainAmount -= 80;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
