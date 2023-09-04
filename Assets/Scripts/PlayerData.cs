using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    

    public static int BaseBallBatAmount;
    public int BaseBallBatEquipedAmount;

    public static int ChainSawAmount;
    public int ChainSawEquipedAmount;

    public static int AxeAmount;
    public int AxeEquipedAmount;

    public static int MachineGunAmount;
    public int MachineGunEquipedAmount;

    public static int FlameThrowerAmount;
    public int FlameThrowerEquipedAmount;

    public static int GozillaHeadAmount;
    public int GozillaHeadEquipedAmount;

    public float baseBallBatAmount;
    public float chainSawAmount;
    public float axeAmount;
    public float machineGunAmount;
    public float flameThrowerAmount;
    public float gozillaHeadAmount;



    private void Start()
    {
    }

    public void Awake()
    {
        BaseBallBatAmount = PlayerPrefs.GetInt("BaseBallBatAmount", 1);

        ChainSawAmount = PlayerPrefs.GetInt("ChainSawAmount", 0);

        AxeAmount = PlayerPrefs.GetInt("AxeAmount", 0);
        

        MachineGunAmount = PlayerPrefs.GetInt("MachineGunAmount", 1);
        
        FlameThrowerAmount = PlayerPrefs.GetInt("FlameThrowerAmount", 1);

        GozillaHeadAmount = PlayerPrefs.GetInt("GozillaHeadAmount", 0);
    }

    public void Update()
    {
        baseBallBatAmount = BaseBallBatEquipedAmount;
        chainSawAmount = ChainSawEquipedAmount;
        axeAmount = AxeEquipedAmount;
        machineGunAmount = MachineGunEquipedAmount;
        flameThrowerAmount = FlameThrowerEquipedAmount;
        gozillaHeadAmount = GozillaHeadEquipedAmount;

    }



}
