using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private ParticleSystem particle;

    public GameObject Lasers;

    public GameObject DamagedThings;


    private void Start()
    {
        Lasers.SetActive(false);
    }

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void Update()
    {

    }

    public void OnPointDownLaser()
    {
        Lasers.SetActive(true);
        particle.Play();
    }

    public void OnPointUpLaser()
    {
        Lasers.SetActive(false);
    }
}
