using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ava69 : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "0xb5f876a2b518bb03a2e1137b627b30a92fba55d4";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0 && NFT69Main.NFt69Amount == 0)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt += 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT69Main.NFt69Amount += 1;
            PlayerPrefs.SetInt("NFt69Amount", NFT69Main.NFt69Amount);

            SKYBITToken.SkyBitTokengainAmount += 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
        else if (balanceOf <= 0 && NFT69Main.NFt69Amount == 1)
        {
            AmountOFNFTHOLD.amountOfFirstKrazyKongNFt -= 1;
            PlayerPrefs.SetInt("amountOfFirstKrazyKongNFt", AmountOFNFTHOLD.amountOfFirstKrazyKongNFt);

            NFT69Main.NFt69Amount -= 1;
            PlayerPrefs.SetInt("NFt69Amount", NFT69Main.NFt69Amount);

            SKYBITToken.SkyBitTokengainAmount -= 20;
            PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);
        }
    }
}
