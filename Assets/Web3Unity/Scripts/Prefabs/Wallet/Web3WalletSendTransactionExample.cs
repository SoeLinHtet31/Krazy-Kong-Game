using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web3WalletSendTransactionExample : MonoBehaviour
{
 async public void OnSendTransaction()
    {
        // https://chainlist.org/
        string chainId = "5"; // goerli
        // account to send to
        string to = "0xF97833Ad9f2e096d53122752cF33C0930A4390a4";
        // value in wei
        string value = "12300000000000000";
        // data OPTIONAL
        string data = "";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // send transaction
        string response = await Web3Wallet.SendTransaction(chainId, to, value, data, gasLimit, gasPrice);
        print(response);
    }
}
