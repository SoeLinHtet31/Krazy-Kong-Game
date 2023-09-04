using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UpgradeBaseBallBat : MonoBehaviour
{
    public GameObject upgradeDamage;
    public GameObject upgradeAttackSpeed;
    public GameObject upgradeCooldown;

    public GameObject BaseBallBatUpgradePage;
    public GameObject WeaponPage;

    public TextMeshProUGUI KongSAmount;

    public GameObject SKYBITTokenShow;
    public GameObject KongSShow;

    public static int UprageDamageAmount;
    public static int upgradeAttackSpeedAmount;
    public static int upgradeCooldownAmount;

    public GameObject BackButton;

    private void Awake()
    {


        UprageDamageAmount = PlayerPrefs.GetInt("UprageDamageAmount", 0);
        upgradeAttackSpeedAmount = PlayerPrefs.GetInt("upgradeAttackSpeedAmount", 0);
        upgradeCooldownAmount = PlayerPrefs.GetInt("upgradeCooldownAmount", 0);
    }

    private void Update()
    {
        KongSAmount.text = PlayerMoney.numberOfCoin.ToString();

        if (PlayerMoney.numberOfCoin >= 1000 && UprageDamageAmount <= 10)
        {
            upgradeDamage.SetActive(true);

        }
        else if (PlayerMoney.numberOfCoin <= 999 || UprageDamageAmount >= 11)
        {
            upgradeDamage.SetActive(false);
        }

        if (PlayerMoney.numberOfCoin >= 1000 && upgradeAttackSpeedAmount <= 10)
        {
            upgradeAttackSpeed.SetActive(true);


        }
        else if (PlayerMoney.numberOfCoin <= 999 || upgradeAttackSpeedAmount >= 11)
        {
            upgradeAttackSpeed.SetActive(false);
        }

        if (PlayerMoney.numberOfCoin >= 1000 && upgradeCooldownAmount <= 4)
        {
            upgradeCooldown.SetActive(true);


        }
        else if (PlayerMoney.numberOfCoin <= 999 || upgradeCooldownAmount >= 4)
        {
            upgradeCooldown.SetActive(false);
        }
    }

    public void UpgradeDamage()
    {
        BaseBallBatData.Damage += 5f;
        PlayerPrefs.SetFloat("BaseBallBatDamage", BaseBallBatData.Damage);

        UprageDamageAmount += 1;
        PlayerPrefs.SetInt("UprageDamageAmount", UprageDamageAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void UpgradeAttackSpeed()
    {
        BaseBallBatData.AttackSpeed += 0.5f;
        PlayerPrefs.SetFloat("BaseBallBatAttackSpeed", BaseBallBatData.AttackSpeed);

        upgradeAttackSpeedAmount += 1;
        PlayerPrefs.SetInt("upgradeAttackSpeedAmount", upgradeAttackSpeedAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void UpgradeCooldown()
    {
        BaseBallBatData.Cooldown -= 0.05f;
        PlayerPrefs.SetFloat("baseBallBatCooldown", BaseBallBatData.Cooldown);

        upgradeCooldownAmount += 1;
        PlayerPrefs.SetInt("upgradeCooldownAmount", upgradeCooldownAmount);

        PlayerMoney.numberOfCoin -= 1000;
        PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
    }

    public void Exit()
    {
        BackButton.SetActive(false);
        SKYBITTokenShow.SetActive(true);
        KongSShow.SetActive(true);
        BaseBallBatUpgradePage.SetActive(false);
        WeaponPage.SetActive(true);
    }

    public void ReturnToAdventure(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
