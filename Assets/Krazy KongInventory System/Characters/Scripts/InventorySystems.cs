using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystems : MonoBehaviour
{
    public GameObject CharacterSelection;
    public GameObject WeaponSelection;
    public GameObject Materials;
    public GameObject Materials2;
    public GameObject CraftingPage;

    public GameObject PrisonerKongUpgradePage;

    public GameObject BaseBallBatUpgradePage;

    public GameObject SKYBITTokenShow;
    public GameObject KongSShow;

    public GameObject BackFromPrisonKongUpgradeButton;
    public GameObject BackFromPrisonKongUpgradeButton2;

    public void OnPressToCharacters()
    {
        CharacterSelection.SetActive(true);
        WeaponSelection.SetActive(false);
        Materials.SetActive(false);
        Materials2.SetActive(false);
        CraftingPage.SetActive(false);
    }

    public void OnPressToWeapons()
    {
        CharacterSelection.SetActive(false);
        WeaponSelection.SetActive(true);
        Materials.SetActive(false);
        Materials2.SetActive(false);
        CraftingPage.SetActive(false);
    }

    public void OnPressToMaterials()
    {
        CharacterSelection.SetActive(false);
        WeaponSelection.SetActive(false);
        Materials.SetActive(true);
        Materials2.SetActive(true);
        CraftingPage.SetActive(false);
    }






    public void OnPressToPrisonerKongUpgradePage()
    {
        BackFromPrisonKongUpgradeButton.SetActive(true);
        SKYBITTokenShow.SetActive(false);
        KongSShow.SetActive(false);
        PrisonerKongUpgradePage.SetActive(true);
        CharacterSelection.SetActive(false);
    }

    public void OnPressToBaseBallBatUpgradePage()
    {
        BackFromPrisonKongUpgradeButton2.SetActive(true);
        SKYBITTokenShow.SetActive(false);
        KongSShow.SetActive(false);
        BaseBallBatUpgradePage.SetActive(true);
        WeaponSelection.SetActive(false);
    }
}
