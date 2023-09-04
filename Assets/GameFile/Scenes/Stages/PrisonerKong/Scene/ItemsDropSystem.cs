using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsDropSystem : MonoBehaviour
{
    public static int PrisonerKongShard;

    public static int ExpotionAmount;

    public static int BaseBallShards;

    public static int MichealKongShards;

    public static int PimpKongShards;

    public static int FlameThrowerWeaponShards;

    public static int MachineGunShards;

    public static int GozillaHeadShard;

    private void Awake()
    {
        PrisonerKongShard = PlayerPrefs.GetInt("PrisonerKongShard", 0);

        ExpotionAmount = PlayerPrefs.GetInt("ExpotionAmount", 0);

        BaseBallShards = PlayerPrefs.GetInt("BaseBallShards", 0);

        MichealKongShards = PlayerPrefs.GetInt("MichealKongShards", 0);

        PimpKongShards = PlayerPrefs.GetInt("PimpKongShards", 0);

        FlameThrowerWeaponShards = PlayerPrefs.GetInt("FlameThrowerWeaponShards", 0);

        MachineGunShards = PlayerPrefs.GetInt("MachineGunShards", 0);

        GozillaHeadShard = PlayerPrefs.GetInt("GozillaHeadShard", 0);

    }

    
    

}

