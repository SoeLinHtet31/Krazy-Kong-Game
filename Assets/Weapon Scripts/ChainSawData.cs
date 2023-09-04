using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSawData : MonoBehaviour
{
    public float damage;
    public float attackSpeed;
    public float level;
    public float cooldown;

    public static int Level;

    public static int Damage;

    public static int AttackSpeed;

    public static int Cooldown;



    private void Awake()
    {
        // AttackSpeed
        AttackSpeed = PlayerPrefs.GetInt("ChainSawAttackSpeed", 1);
        attackSpeed = AttackSpeed;


        // Damage
        Damage = PlayerPrefs.GetInt("ChainSawDamage", 10);
        damage = Damage;


        // Cooldown;
        Cooldown = PlayerPrefs.GetInt("ChainSawCooldown", 2);
        cooldown = Cooldown;

        // Level
        Level = PlayerPrefs.GetInt("ChainSawLevel", 0);
        level = Level;
    }

}
