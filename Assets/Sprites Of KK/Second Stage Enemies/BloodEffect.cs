using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodEffect : MonoBehaviour
{
    private ParticleSystem particle;


    private void Start()
    {

    }

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void Update()
    {

        
    }

    public void Play()
    {
        particle.Play();
    }
    public void Stop()
    {
        particle.Stop();
    }

}
