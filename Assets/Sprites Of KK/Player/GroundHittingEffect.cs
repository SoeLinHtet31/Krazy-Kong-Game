using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHittingEffect : MonoBehaviour
{
    public ParticleSystem GroundHitEffect;
    public Transform HittingEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            HittingEffect.transform.position = gameObject.transform.position;
            GroundHitEffect.Play();
        }
    }
}
