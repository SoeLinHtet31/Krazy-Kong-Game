using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBallBatData : MonoBehaviour
{
    public float damage;
    public float attackSpeed;
    public int level;
    public float cooldown;

    public static int Level;

    public static float Damage;

    public static float AttackSpeed;

    public static float Cooldown;



    private void Awake()
    {
        // AttackSpeed
        AttackSpeed = PlayerPrefs.GetFloat("BaseBallBatAttackSpeed", 2f);


        // Damage
        Damage = PlayerPrefs.GetFloat("BaseBallBatDamage", 10f);


        // Cooldown;
        Cooldown = PlayerPrefs.GetFloat("baseBallBatCooldown", 0.25f);

        // Level
        Level = PlayerPrefs.GetInt("BaseBallBatLevel", 0);

    }

    private void Update()
    {
        attackSpeed = AttackSpeed;
        damage = Damage;
        cooldown = Cooldown;
    }

}
