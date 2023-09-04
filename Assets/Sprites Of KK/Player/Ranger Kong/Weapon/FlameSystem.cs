using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlameSystem : MonoBehaviour
{
    public ParticleSystem particle;
    public FlameThrowerAttackSystem FlameAttack;

    public GameObject Player;

    private Animator anim;
    public float Damage;

    public static int PCMode;
    public int CheckPCmode;

    public bool isPressed;

    List<ParticleCollisionEvent> colEvent = new List<ParticleCollisionEvent>();


    private void Start()
    {
        anim = GetComponent<Animator>();
        PCMode = 0;
    }

    // Start is called before the first frame update
    public void Update()
    {
        CheckPCmode = PCMode;
        if (isPressed)
        {
            FlameAttack.Attack();
            particle.Play();
        }
        else if (!isPressed)
        {
            particle.Stop();
        }

        if (Input.GetMouseButtonDown(0) && PCMode >= 1)
        {
            isPressed = true;
        }
        else if (Input.GetMouseButtonUp(0) && PCMode >= 1)
        {
            isPressed = false;
        }

        if (Player.transform.localScale.x == 1 && isPressed == true)
        {
            anim.SetTrigger("TurnLeft");
        }
        else if (Player.transform.localScale.x == -1 && isPressed == true)
        {
            anim.SetTrigger("TurnRight");
        }

    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.TryGetComponent(out EnemyHealth en))
        {
            en.TakeDamage(1f);
            en.FlameActive();
        }      

        if (other.TryGetComponent(out Stage2MeleeEnemyHealth Stage2En1))
        {
            Stage2En1.TakeDamage(1f);
            Stage2En1.FlameActive();
        }

        if (other.TryGetComponent(out Stage2EnemyRangerHealth Stage2En2))
        {
            Stage2En2.TakeDamage(1f);
            Stage2En2.FlameActive();
        }

        if (other.TryGetComponent(out BossHealth boss))
        {
            boss.TakeDamage(1f);
            boss.FlameActive();
        }

        if (other.TryGetComponent(out SecondStageBossHealth boss2))
        {
            boss2.TakeDamage(1f);
            boss2.FlameActive();
        }


        if (other.TryGetComponent(out TorrretEnemyHealth torret))
        {
            torret.TakeDamage(1f);
            torret.FlameActive();
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



    public void OnPointerDown()
    {
        isPressed = true;
        particle.Play();
    }
    public void OnPointerUp()
    {
        isPressed = false;
        particle.Stop();
    }
}

