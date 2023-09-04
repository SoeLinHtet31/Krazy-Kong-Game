using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol80 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xd825501c12a4ebc1e90720931068c80b504777c1";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT80Main.NFt80Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT80Main.NFt80Amount += 1;
            PlayerPrefs.SetInt("NFt80Amount", NFT80Main.NFt80Amount);

            SKYBITToken.SkyBitTokengainAmount += 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT80Main.NFt80Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT80Main.NFt80Amount -= 1;
            PlayerPrefs.SetInt("NFt80Amount", NFT80Main.NFt80Amount);

            SKYBITToken.SkyBitTokengainAmount -= 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
