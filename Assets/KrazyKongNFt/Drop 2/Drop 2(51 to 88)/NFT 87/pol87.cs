using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol87 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xfcb6afc452a9bdf3a6d993c7966e29cd1997e3ce";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT87Main.NFt87Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT87Main.NFt87Amount += 1;
            PlayerPrefs.SetInt("NFt87Amount", NFT87Main.NFt87Amount);

            SKYBITToken.SkyBitTokengainAmount += 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT87Main.NFt87Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT87Main.NFt87Amount -= 1;
            PlayerPrefs.SetInt("NFt87Amount", NFT87Main.NFt87Amount);

            SKYBITToken.SkyBitTokengainAmount -= 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
