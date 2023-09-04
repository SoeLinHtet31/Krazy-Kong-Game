using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntermediateBox : MonoBehaviour
{
    public ShopNumberGenerator NumberGenerator1;

    public TextMeshProUGUI GeneratedNumber1;

    public Animator anim;

    public GameObject Open;

    public int skybitAmount;

    public GameObject PrisonerKongShard;
    public GameObject BaseBallBatShard;
    public GameObject MichealKongShard;
    public GameObject PimpKongShard;
    public GameObject FlameThrowerShard;
    public GameObject MachineGunShard;
    public GameObject KongS;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
        skybitAmount = SKYBITToken.numberOfToken;
        if (SKYBITToken.SkybitToken >= 2500 && ShopSystem.OpeningBox == 0)
        {
            Open.SetActive(true);
        }
        else if (SKYBITToken.SkybitToken < 2500 || ShopSystem.OpeningBox < 0)
        {
            Open.SetActive(false);
        }
    }
    public void Drop()
    {
        NumberGenerator1.RandomGenerate();
        SKYBITToken.SkybitToken -= 2500;
        PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
        if ((GeneratedNumber1.text == "1") || (GeneratedNumber1.text == "5") || (GeneratedNumber1.text == "10") || (GeneratedNumber1.text == "15") || (GeneratedNumber1.text == "20") || (GeneratedNumber1.text == "25"))
        {
            PrisonerKongShard.SetActive(true);
            BaseBallBatShard.SetActive(false);
            FlameThrowerShard.SetActive(false);
            MachineGunShard.SetActive(false);
            KongS.SetActive(false);
            ItemsDropSystem.PrisonerKongShard += Random.Range(3, 5);
            PlayerPrefs.SetInt("PrisonerKongShard", ItemsDropSystem.PrisonerKongShard);
        }


        if ((GeneratedNumber1.text == "2") || (GeneratedNumber1.text == "6") || (GeneratedNumber1.text == "11") || (GeneratedNumber1.text == "16") || (GeneratedNumber1.text == "21") || (GeneratedNumber1.text == "26"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(true);
            FlameThrowerShard.SetActive(false);
            MachineGunShard.SetActive(false);
            KongS.SetActive(false);
            ItemsDropSystem.BaseBallShards += Random.Range(3, 5);
            PlayerPrefs.SetInt("BaseBallShards", ItemsDropSystem.BaseBallShards);
        }

        if ((GeneratedNumber1.text == "3") || (GeneratedNumber1.text == "4") || (GeneratedNumber1.text == "7") || (GeneratedNumber1.text == "8") || (GeneratedNumber1.text == "9") || (GeneratedNumber1.text == "12") || (GeneratedNumber1.text == "13")
            || (GeneratedNumber1.text == "14") || (GeneratedNumber1.text == "17") || (GeneratedNumber1.text == "18") || (GeneratedNumber1.text == "19") || (GeneratedNumber1.text == "22"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(false);
            FlameThrowerShard.SetActive(false);
            MachineGunShard.SetActive(false);
            KongS.SetActive(true);
            PlayerMoney.numberOfCoin += 100;
            PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
        }

        if ((GeneratedNumber1.text == "27") || (GeneratedNumber1.text == "28") || (GeneratedNumber1.text == "23"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(false);
            FlameThrowerShard.SetActive(true);
            MachineGunShard.SetActive(false);
            KongS.SetActive(false);
            ItemsDropSystem.FlameThrowerWeaponShards += Random.Range(5, 10);
            PlayerPrefs.SetInt("FlameThrowerWeaponShards", ItemsDropSystem.FlameThrowerWeaponShards);
        }

        if ((GeneratedNumber1.text == "29") || (GeneratedNumber1.text == "30") || (GeneratedNumber1.text == "24"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(false);
            FlameThrowerShard.SetActive(false);
            MachineGunShard.SetActive(true);
            KongS.SetActive(false);
            ItemsDropSystem.MachineGunShards += Random.Range(5, 10);
            PlayerPrefs.SetInt("MachineGunShards", ItemsDropSystem.MachineGunShards);
        }

        Open.SetActive(false);
        Invoke("Reset", 1.5f);
    }
    public void Reset()
    {
        ShopSystem.OpeningBox += 5;
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(false);
        FlameThrowerShard.SetActive(false);
        MachineGunShard.SetActive(false);
        KongS.SetActive(false);
        anim.SetTrigger("Reset");
    }

    public void ResetAll()
    {
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(false);
        FlameThrowerShard.SetActive(false);
        MachineGunShard.SetActive(false);
        KongS.SetActive(false);
        anim.SetTrigger("Reset");
    }
}
