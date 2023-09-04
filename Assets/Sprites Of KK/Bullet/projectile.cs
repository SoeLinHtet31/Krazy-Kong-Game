using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{


    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime;
    public float Damage;
    [SerializeField] private float resetTime;
    private BoxCollider2D box;

    private Animator anim;

    


    private void Awake()
    {
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
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
            collision.GetComponent<EnemyHealth>().TakeDamage(Damage);

        if (collision.tag == "TorretEnemy")
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(Damage);

        if (collision.tag == "Boss")
            collision.GetComponentInParent<BossHealth>().TakeDamage(Damage);

        if (collision.tag == "SecondStageEnemies")
            collision.GetComponent<SecStageEneHealth>().TakeDamage(Damage);
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
