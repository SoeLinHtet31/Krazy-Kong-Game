using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerAction : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] Bullets;
    public static float attackCooldown;

    private float cooldownTimer = Mathf.Infinity;

    public bool isPressed = false;

    public static int PCMode;
    public int CheckPCmode;

    private void Start()
    {
        PCMode = 0;
    }
    private void Awake()
    {
        // Cooldown;
        attackCooldown = PlayerPrefs.GetFloat("FlameThrowerattackCooldown", 0.15f);
    }

    private void Update()
    {

        CheckPCmode = PCMode;
        if (isPressed)
        {

            Attacks();
        }
        cooldownTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && PCMode >= 1)
        {
            isPressed = true;
        }
        else if (Input.GetMouseButtonUp(0) && PCMode >= 1)
        {
            isPressed = false;
        }

    }

    public void Attacks()
    {
        if (cooldownTimer > attackCooldown)
        {
            cooldownTimer = 0;
            Bullets[FindBullets()].transform.position = FirePoint.position;
            Bullets[FindBullets()].GetComponent<FlameThrowerFlameProjectiles>().SetDirection(Mathf.Sign(transform.localScale.x));
        }
    }
    private int FindBullets()
    {
        for (int i = 0; i < Bullets.Length; i++)
        {
            if (!Bullets[i].activeInHierarchy)
                return i;
        }
        return 0;
    }

    public void OnPointerDown()
    {
        isPressed = true;
    }
    public void OnPointerUp()
    {
        isPressed = false;
    }
}
