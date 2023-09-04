using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class eth7 : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x07f638821acf587c884a4ab90015673848bb2016";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT7Main.NFt7Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT7Main.NFt7Amount += 1;
            PlayerPrefs.SetInt("NFt7Amount", NFT7Main.NFt7Amount);

            SKYBITToken.SkyBitTokengainAmount += 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT7Main.NFt7Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT7Main.NFt7Amount -= 1;
            PlayerPrefs.SetInt("NFt7Amount", NFT7Main.NFt7Amount);

            SKYBITToken.SkyBitTokengainAmount -= 40;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
