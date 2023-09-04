using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponSystem : MonoBehaviour
{
    public TextMeshProUGUI baseBallBatAmount;

    public TextMeshProUGUI FlameThrowerAmount;


    public TextMeshProUGUI MachineGunAmount;

    public GameObject BaseBallBat;
    public GameObject FlameThrower;
    public GameObject MachineGun;

    public GameObject BaseBallBatFake;
    public GameObject FlameThrowerFake;
    public GameObject MachineGunFake;



    public void Awake()
    {
    }

    private void Update()
    {
        if (PlayerData.BaseBallBatAmount >= 1)
        {
            BaseBallBat.SetActive(true);
            BaseBallBatFake.SetActive(false);
        }
        else if (PlayerData.BaseBallBatAmount <= 0)
        {
            BaseBallBat.SetActive(false);
            BaseBallBatFake.SetActive(true);
        }


        if (PlayerData.FlameThrowerAmount >= 1)
        {
            FlameThrower.SetActive(true);
            FlameThrowerFake.SetActive(false);
        }
        else if (PlayerData.FlameThrowerAmount <= 0)
        {
            FlameThrower.SetActive(false);
            FlameThrowerFake.SetActive(true);
        }


        if (PlayerData.MachineGunAmount >= 1)
        {
            MachineGun.SetActive(true);
            MachineGunFake.SetActive(false);
        }
        else if (PlayerData.MachineGunAmount <= 0)
        {
            MachineGun.SetActive(false);
            MachineGunFake.SetActive(true);
        }


        baseBallBatAmount.text = PlayerData.BaseBallBatAmount.ToString();


        FlameThrowerAmount.text = PlayerData.FlameThrowerAmount.ToString();


        MachineGunAmount.text = PlayerData.MachineGunAmount.ToString();

    }
}
