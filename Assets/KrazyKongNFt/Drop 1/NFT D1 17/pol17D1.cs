using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol17D1 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "170855686977898187156779233823671782751670215276";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFTD1Main17.NFt17D1Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFTD1Main17.NFt17D1Amount += 1;
            PlayerPrefs.SetInt("NFt17D1Amount", NFTD1Main17.NFt17D1Amount);

            SKYBITToken.SkyBitTokengainAmount += 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFTD1Main17.NFt17D1Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFTD1Main17.NFt17D1Amount -= 1;
            PlayerPrefs.SetInt("NFt17D1Amount", NFTD1Main17.NFt17D1Amount);

            SKYBITToken.SkyBitTokengainAmount -= 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
