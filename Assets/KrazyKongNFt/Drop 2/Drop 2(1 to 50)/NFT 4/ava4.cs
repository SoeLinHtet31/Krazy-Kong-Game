using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava4 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0x05c4a9357b658d862d7a6713fbd0e15666716fd5";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT4Main.NFt4Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT4Main.NFt4Amount += 1;
            PlayerPrefs.SetInt("NFt4Amount", NFT4Main.NFt4Amount);

            SKYBITToken.SkyBitTokengainAmount += 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT4Main.NFt4Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT4Main.NFt4Amount -= 1;
            PlayerPrefs.SetInt("NFt4Amount", NFT4Main.NFt4Amount);

            SKYBITToken.SkyBitTokengainAmount -= 60;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
