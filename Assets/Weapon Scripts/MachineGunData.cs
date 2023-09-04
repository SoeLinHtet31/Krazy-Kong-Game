using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunData : MonoBehaviour
{
    public float damage;
    public int attackSpeed;
    public int level;

    public float resetTime;

    public static int Level;

    public static float Damage;

    public static int AttackSpeed;

    public static float BulletResetTime;

    private void Awake()
    {
        // AttackSpeed
        AttackSpeed = PlayerPrefs.GetInt("MachineGunAttackSpeed", 88);
        attackSpeed = AttackSpeed;

        // Damage
        Damage = PlayerPrefs.GetFloat("MachineGunDamage", 5);
        damage = Damage;


        // Level
        Level = PlayerPrefs.GetInt("MachineGunLevel", 0);
        level = Level;


        // ResetTime
        BulletResetTime = PlayerPrefs.GetFloat("MachineGunBulletResetTime", 0.25f);
        resetTime = BulletResetTime;
    }

}
