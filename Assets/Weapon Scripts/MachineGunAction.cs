using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunAction : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] Bullets;
    public static float attackCooldown;

    public AudioSource BulletSound;
   
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
        attackCooldown = PlayerPrefs.GetFloat("MachineGunattackCooldown", 0.25f);
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
            BulletSound.Play();
        }
        else if (Input.GetMouseButtonUp(0) && PCMode >= 1)
        {
            isPressed = false;
            BulletSound.Stop();
        }

    }

    public void Attacks()
    {
        if (cooldownTimer > attackCooldown)
        {
            cooldownTimer = 0;
            Bullets[FindBullets()].transform.position = FirePoint.position;
            Bullets[FindBullets()].GetComponent<MachineGunProjectile>().SetDirection(Mathf.Sign(transform.localScale.x));
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
        BulletSound.Play();
    }
    public void OnPointerUp()
    {
        isPressed = false;
        BulletSound.Stop();
    }
}
