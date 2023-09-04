using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float SlimeCurrentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    public GameObject Slime;


    public Transform KongS1;
    public GameObject KongS;

    public Transform KongS2;
    public GameObject KongS22;


    public GameObject HealthBar;

    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;


    private void Awake()
    {
        SlimeCurrentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        SlimeCurrentHealth -= _damage;
        if (SlimeCurrentHealth > 0)
        {
            anim.SetTrigger("hurt");
            HealthBar.SetActive(true);

        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");

                //Deactivate all attached component classes
                foreach (Behaviour component in components)
                    component.enabled = false;

                dead = true;
                KongS.SetActive(true);
                KongS1.transform.position = Slime.transform.position;
                KongS22.SetActive(true);
                KongS22.transform.position = Slime.transform.position;
            }
        }
    }
    public void Deactivated()
    {
        gameObject.SetActive(false);
    }
}
