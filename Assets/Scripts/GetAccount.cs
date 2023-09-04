using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetAccount : MonoBehaviour
{
    public TextMeshProUGUI myAccount;
    public TextMeshProUGUI myshowAccount;

    public GameObject userProfile;

    public TextMeshProUGUI amountOfNFtOwn;

    private void Start()
    {
        Time.timeScale = 1f;
        string account = PlayerPrefs.GetString("Account");
        myAccount.text = account;
    }

    private void Update()
    {
        amountOfNFtOwn.text = AmountOFNFTHOLD.amountOfFirstKrazyKongNFt.ToString();
        myshowAccount.text = myAccount.text;
    }

    public void OnClickToProfile()
    {
        userProfile.SetActive(true);
        
    }

    public void OnExitFromProfile()
    {
        userProfile.SetActive(false);
    }
}
