using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class pol20 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Polygon";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x1d51ac4d52b715f40814fcb6f6932f6a0e211cd1";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT20Main.NFt20Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT20Main.NFt20Amount += 1;
            PlayerPrefs.SetInt("NFt20Amount", NFT20Main.NFt20Amount);

            SKYBITToken.SkyBitTokengainAmount += 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT20Main.NFt20Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT20Main.NFt20Amount -= 1;
            PlayerPrefs.SetInt("NFt20Amount", NFT20Main.NFt20Amount);

            SKYBITToken.SkyBitTokengainAmount -= 100;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
