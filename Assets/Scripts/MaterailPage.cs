using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaterailPage : MonoBehaviour
{
    public GameObject Page1;
    public GameObject Page2;

    public GameObject Materials;
    public GameObject CraftingPage;
    public GameObject PrisonerKongShard;
    public GameObject BaseBallBatShard;
    public GameObject FlameThrowerShard;
    public GameObject MachineGunShard;

    public GameObject PrisonerKong;
    public GameObject BaseBallBat;
    public GameObject FlameThrower;
    public GameObject MachineGUn;

    public TextMeshProUGUI PrisonerKongShardAmount;
    public TextMeshProUGUI BaseBallBatShardAmount;
    public TextMeshProUGUI FlameThrowerShardAmount;
    public TextMeshProUGUI MachineGunShardAmount;

    private void Update()
    {
        PrisonerKongShardAmount.text = ItemsDropSystem.PrisonerKongShard.ToString();
        BaseBallBatShardAmount.text = ItemsDropSystem.BaseBallShards.ToString();
        FlameThrowerShardAmount.text = ItemsDropSystem.FlameThrowerWeaponShards.ToString();
        MachineGunShardAmount.text = ItemsDropSystem.MachineGunShards.ToString();
    }

    public void GotoPage2()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }

    public void GotoPage1()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }

    public void OnPressToPrisonerKongCrafting()
    {
        Materials.SetActive(false);
        PrisonerKong.SetActive(true);
        BaseBallBat.SetActive(false);
        CraftingPage.SetActive(true);
        FlameThrower.SetActive(false);
        FlameThrowerShard.SetActive(false);
        MachineGunShard.SetActive(false);
        MachineGUn.SetActive(false);
        Materials.SetActive(false);
        PrisonerKongShard.SetActive(true);
        BaseBallBatShard.SetActive(false);
    }

    public void OnPressToBaseBallBatCrafting()
    {
        PrisonerKong.SetActive(false);
        BaseBallBat.SetActive(true);
        FlameThrower.SetActive(false);
        FlameThrowerShard.SetActive(false);
        MachineGunShard.SetActive(false);
        MachineGUn.SetActive(false);
        Materials.SetActive(false);
        CraftingPage.SetActive(true);
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(true);
    }

    public void OnPressToFlameThrowerCrafting()
    {
        PrisonerKong.SetActive(false);
        BaseBallBat.SetActive(false);
        FlameThrower.SetActive(true);
        FlameThrowerShard.SetActive(true);
        MachineGunShard.SetActive(false);
        MachineGUn.SetActive(false);
        Materials.SetActive(false);
        Materials.SetActive(false);
        CraftingPage.SetActive(true);
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(false);
    }

    public void OnPressToMachineGunCrafting()
    {
        PrisonerKong.SetActive(false);
        BaseBallBat.SetActive(false);
        FlameThrower.SetActive(false);
        FlameThrowerShard.SetActive(false);
        MachineGunShard.SetActive(true);
        MachineGUn.SetActive(true);
        Materials.SetActive(false);
        Materials.SetActive(false);
        CraftingPage.SetActive(true);
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(false);
    }
}
