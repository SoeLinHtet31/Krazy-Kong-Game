using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecStageEneHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    public GameObject Enemy;

    public GameObject KongS;

    public Transform Kongs;

    public GameObject KongS2;
    public Transform kongS2;

    public GameObject HealthBar;

    public GameObject Effect;

    private BoxCollider2D box;



    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        box.enabled = true;
    }


    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");

        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                box.enabled = false;

                Effect.SetActive(false);

                //Deactivate all attached component classes
                foreach (Behaviour component in components)
                    component.enabled = false;

                dead = true;
                KongS2.SetActive(true);
                kongS2.transform.position = Enemy.transform.position;
                KongS.SetActive(true);
                Kongs.transform.position = Enemy.transform.position;
                HealthBar.SetActive(false);
                KongS2.SetActive(true);
                kongS2.transform.position = Enemy.transform.position;
            }
        }
    }
    public void Deactivated()
    {
        Enemy.SetActive(false);
    }
}
