using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerFlameProjectiles : MonoBehaviour
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
        resetTime = FlameThrowerData.BulletResetTime;
        Damage = FlameThrowerData.Damage;
        speed = FlameThrowerData.AttackSpeed;

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
        hit = true;
        anim.SetTrigger("Explode");
        box.enabled = false;

        if (collision.tag == "Enemy")
            collision.GetComponent<EnemyHealth>().TakeDamage(FlameThrowerData.Damage);

        if (collision.tag == "TorretEnemy")
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(FlameThrowerData.Damage);


        if (collision.tag == "Boss")
            collision.GetComponent<BossHealth>().TakeDamage(FlameThrowerData.Damage);

        if (collision.tag == "SecondStageEnemies")
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(FlameThrowerData.Damage);

        if (collision.tag == "Stage2MeleeEnemy")
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(FlameThrowerData.Damage);
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
