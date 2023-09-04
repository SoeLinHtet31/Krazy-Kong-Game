using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PrisonerKongUpgrade : MonoBehaviour
{
    public GameObject upgradeHealth;
    public GameObject upgradeMoveSpeed;
    public GameObject upgradeSKYBITGain;

    public GameObject PrisonerKongUpgradePage;
    public GameObject CharacterPage;

    public TextMeshProUGUI KongSAmount;

    public GameObject SKYBITTokenShow;
    public GameObject KongSShow;

    public static int UprageHealthAmount;
    public static int upgradeMoveSpeedAmount;
    public static int upgradeSKYBITGainAmount;

    public GameObject BackButton;

 

    private void Awake()
    {
        

        UprageHealthAmount = PlayerPrefs.GetInt("UprageHealthAmount", 0);
        upgradeMoveSpeedAmount = PlayerPrefs.GetInt("upgradeMoveSpeedAmount", 0);
        upgradeSKYBITGainAmount = PlayerPrefs.GetInt("upgradeSKYBITGainAmount", 0);
    }

    private void Update()
    {
        KongSAmount.text = PlayerMoney.numberOfCoin.ToString();

        if (PlayerMoney.numberOfCoin >= 1000 && UprageHealthAmount <= 10)
        {
            upgradeHealth.SetActive(true);

        }
        else if (PlayerMoney.numberOfCoin <= 999|| UprageHealthAmount >= 11)
        {
            upgradeHealth.SetActive(false);
        }

        if (PlayerMoney.numberOfCoin >= 1000 && upgradeMoveSpeedAmount <= 10)
        {
            upgradeMoveSpeed.SetActive(true);

            
        }
        else if (PlayerMoney.numberOfCoin <= 999 || upgradeMoveSpeedAmount >= 11)
        {
            upgradeMoveSpeed.SetActive(false);
        }

        if (PlayerMoney.numberOfCoin >= 1000 && upgradeSKYBITGainAmount <= 10 && AmountOFNFTHOLD.amountOfFirstKrazyKongNFt >= 1)
        {
            upgradeSKYBITGain.SetActive(true);

           
        }
        else if (PlayerMoney.numberOfCoin <= 999 || upgradeSKYBITGainAmount >= 11 || AmountOFNFTHOLD.amountOfFirstKrazyKongNFt < 1)
        {
            upgradeSKYBITGain.SetActive(false);
        }
    }

    public void UpgradeHealth()
    {
        PrisonerKongData.PrisonerKongHealth += 100;
        PlayerPrefs.SetInt("prisonerKongHealth", PrisonerKongData.PrisonerKongHealth);

        PrisonerKongData.gotHealthUpgrade += 1;
        Invoke("resetHealthUpgrade", 0.1f);

        UprageHealthAmount += 1;
        PlayerPrefs.SetInt("UprageHealthAmount", UprageHealthAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void UpgradeMoveSpeed()
    {
        PrisonerKongData.PrisonerKongSpeed += 1f;
        PlayerPrefs.SetFloat("PrisonerKongSpeed", PrisonerKongData.PrisonerKongSpeed);

        upgradeMoveSpeedAmount += 1;
        PlayerPrefs.SetInt("upgradeMoveSpeedAmount", upgradeMoveSpeedAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void UpgradeSkyBitGain()
    {
        SKYBITToken.SkyBitTokengainAmount += 10;
        PlayerPrefs.SetInt("skyBitTokengainAmount", SKYBITToken.SkyBitTokengainAmount);

        upgradeSKYBITGainAmount += 1;
        PlayerPrefs.SetInt("upgradeSKYBITGainAmount", upgradeSKYBITGainAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void resetHealthUpgrade()
    {
        PrisonerKongData.gotHealthUpgrade -= 1;
    }
    public void Exit()
    {
        BackButton.SetActive(false);
        SKYBITTokenShow.SetActive(true);
        KongSShow.SetActive(true);
        PrisonerKongUpgradePage.SetActive(false);
        CharacterPage.SetActive(true);
    }

    public void ReturnToAdventure(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
