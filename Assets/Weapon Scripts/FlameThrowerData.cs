using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerData : MonoBehaviour
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
        AttackSpeed = PlayerPrefs.GetInt("FlameThrowerSpeed", 15);
        attackSpeed = AttackSpeed;

        // Damage
        Damage = PlayerPrefs.GetFloat("FlameThrowerDamage", 10f);
        damage = Damage;


        // Level
        Level = PlayerPrefs.GetInt("FlameThrowerLevel", 0);
        level = Level;


        // ResetTime
        BulletResetTime = PlayerPrefs.GetFloat("FlameThrowerResetTime", 0.5f);
        resetTime = BulletResetTime;
    }
}
