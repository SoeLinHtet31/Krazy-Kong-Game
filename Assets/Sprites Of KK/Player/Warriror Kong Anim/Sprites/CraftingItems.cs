using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftingItems : MonoBehaviour
{
    public TextMeshProUGUI PrisonerKongSHard;
    public TextMeshProUGUI BaseBallBatShard;
    public TextMeshProUGUI FlameThrowerSHard;
    public TextMeshProUGUI MachineGunShard;

    public int PrisonerKongSHardAmount;
    public int BaseBallBatShardAmount;
    public int FlameThrowerSHardAmount;
    public int MachineGunShardAmount;


    public GameObject CraftPrisonerKong;
    public GameObject CraftBaseBallBat;
    public GameObject CraftFlameThrower;
    public GameObject CraftMachineGun;

    public Animator PrisonerKong;

    

    public void Awake()
    {
        PrisonerKongSHard.text = ItemsDropSystem.PrisonerKongShard.ToString();
        PrisonerKongSHardAmount = ItemsDropSystem.PrisonerKongShard;

        BaseBallBatShard.text = ItemsDropSystem.BaseBallShards.ToString();
        BaseBallBatShardAmount = ItemsDropSystem.BaseBallShards;

        FlameThrowerSHard.text = ItemsDropSystem.FlameThrowerWeaponShards.ToString();
        FlameThrowerSHardAmount = ItemsDropSystem.FlameThrowerWeaponShards;

        MachineGunShard.text = ItemsDropSystem.MachineGunShards.ToString();
        MachineGunShardAmount = ItemsDropSystem.MachineGunShards;
    }
    private void Update()
    {
        if (ItemsDropSystem.PrisonerKongShard >= 60)
        {
            CraftPrisonerKong.SetActive(true);
            
        }

        if (ItemsDropSystem.PrisonerKongShard < 60)
        {
            CraftPrisonerKong.SetActive(false);
        }


        if (ItemsDropSystem.BaseBallShards >= 30)
        {
            CraftBaseBallBat.SetActive(true);
            
        }
        if (ItemsDropSystem.BaseBallShards < 30)
        {
            CraftBaseBallBat.SetActive(false);
        }


        if (ItemsDropSystem.FlameThrowerWeaponShards >= 60)
        {
            CraftFlameThrower.SetActive(true);

        }
        if (ItemsDropSystem.FlameThrowerWeaponShards < 60)
        {
            CraftFlameThrower.SetActive(false);
        }


        if (ItemsDropSystem.MachineGunShards >= 60)
        {
            CraftMachineGun.SetActive(true);

        }
        if (ItemsDropSystem.MachineGunShards < 60)
        {
            CraftMachineGun.SetActive(false);
        }
    }

    public void CraftePrisonerKong()
    {
        ItemsDropSystem.PrisonerKongShard -= 60;
        PlayerPrefs.SetInt("PrisonerKongShard", ItemsDropSystem.PrisonerKongShard);

        PrisonerKong.SetTrigger("Gain");

        CharacterSystem.PrisonerKongAmount += 1;
        PlayerPrefs.SetInt("PrisonerKongAmount", CharacterSystem.PrisonerKongAmount);
        
    }

    public void CrafteBaseBallBat()
    {
        ItemsDropSystem.BaseBallShards -= 30;
        PlayerPrefs.SetInt("BaseBallShards", ItemsDropSystem.BaseBallShards);

        PlayerData.BaseBallBatAmount += 1;
        PlayerPrefs.SetInt("BaseBallBatAmount", PlayerData.BaseBallBatAmount);
    }

    public void CrafteFlameThrower()
    {
        ItemsDropSystem.FlameThrowerWeaponShards -= 60;
        PlayerPrefs.SetInt("FlameThrowerWeaponShards", ItemsDropSystem.FlameThrowerWeaponShards);

        PlayerData.FlameThrowerAmount += 1;
        PlayerPrefs.SetInt("FlameThrowerAmount", PlayerData.FlameThrowerAmount);
    }

    public void CrafteMachineGun()
    {
        ItemsDropSystem.BaseBallShards -= 60;
        PlayerPrefs.SetInt("BaseBallShards", ItemsDropSystem.BaseBallShards);

        PlayerData.MachineGunAmount += 1;
        PlayerPrefs.SetInt("MachineGunAmount", PlayerData.MachineGunAmount);
    }
}
