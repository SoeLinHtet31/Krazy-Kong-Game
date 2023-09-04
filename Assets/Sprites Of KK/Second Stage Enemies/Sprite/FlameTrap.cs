using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTrap : MonoBehaviour
{
    public ParticleSystem par;
    public GameObject Flame;

    private void Start()
    {
        par.Play();
        Invoke("Stop", 5f);
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    public void Stop()
    {
        par.Stop();
        Invoke("Play", 5f);
    }

    public void Play()
    {
        par.Play();
        Invoke("Stop", 5f);
    }
}
