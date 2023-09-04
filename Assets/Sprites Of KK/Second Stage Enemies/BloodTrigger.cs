using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodTrigger : MonoBehaviour
{
    public BloodEffect Blood;

    private void Awake()
    {

    }

    public void Start()
    {
        Blood.Stop();
    }

    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BloodTrigger")
            Blood.Play();

    }
}
