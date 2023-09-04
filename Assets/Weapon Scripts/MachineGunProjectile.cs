using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunProjectile : MonoBehaviour
{

    public int speed;
    private float direction;
    private bool hit;
    private float lifetime;
    public float Damage;
    public float resetTime;
    private BoxCollider2D box;

    private Animator anim;

    private void Awake()
    {      
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        resetTime = MachineGunData.BulletResetTime;
        Damage = MachineGunData.Damage;
        speed = MachineGunData.AttackSpeed;

        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        if (lifetime > 0.3f)
        {
            box.enabled = true;
        }

        lifetime += Time.deltaTime;
        if (lifetime > resetTime) gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
        }

        if (collision.tag == "Enemy")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<EnemyHealth>().TakeDamage(MachineGunData.Damage);
        }
            

        if (collision.tag == "TorretEnemy")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(MachineGunData.Damage);
        }
            

        if (collision.name == "Stage2 Boss")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<SecondStageBossHealth>().TakeDamage(MachineGunData.Damage);
        }

        if (collision.tag == "Boss")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<BossHealth>().TakeDamage(MachineGunData.Damage);
        }
            

        if (collision.tag == "SecondStageEnemies")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(MachineGunData.Damage);
        }
            

        if (collision.tag == "Stage2MeleeEnemy")
        {
            hit = true;
            anim.SetTrigger("Explode");
            box.enabled = false;
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(MachineGunData.Damage);
        }
            
    }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        box.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }


}
