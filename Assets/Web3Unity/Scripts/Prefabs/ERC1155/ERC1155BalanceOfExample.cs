using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "Avalanche";
        string network = "Mainnet";
        string contract = "0xcb55d0d230f0ba0321954546e7fc815d8e80df44";
        string account = "0x4cfd7a9528f80c43c59b1587b4b77a599637eff3";
        string tokenId = "72403260731390129970840080321327531115950245502";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
