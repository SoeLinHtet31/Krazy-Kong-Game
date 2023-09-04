using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameDamagePlayer : MonoBehaviour
{
    public ParticleSystem particle;
    List<ParticleCollisionEvent> colEvent = new List<ParticleCollisionEvent>();
    public PrisonerKongData player;


    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.name == "Prisoner Kong")
        {
            player.canDie = true;
            PrisonerKongData.curentHealth -= 1;
        }

        int numCollisionEvents = particle.GetCollisionEvents(other, colEvent);

        Rigidbody rb = other.GetComponent<Rigidbody>();
        int i = 1;

        while (i < numCollisionEvents)
        {
            if (rb)
            {
                Vector3 pos = colEvent[i].intersection;
                Vector3 force = colEvent[i].velocity * 10;
                rb.AddForce(force);
            }
            i++;
        }
    }
}
