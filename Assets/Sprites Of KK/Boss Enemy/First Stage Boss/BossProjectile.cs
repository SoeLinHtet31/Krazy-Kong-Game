using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;
    private Rigidbody2D BulletRB;
    public int Damage;
    public bool flip;

    void Start()
    {
        lifetime = 0;
        gameObject.SetActive(true);
        BulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player"); 
    }

    private void Update()
    {
        lifetime += Time.deltaTime;
        if (lifetime > resetTime)
            gameObject.SetActive(false);
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        BulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Vector3 scale = transform.localScale;

        if (target.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);
        }

        transform.localScale = scale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PrisonerKongData.curentHealth -= Damage;
        }
            
        gameObject.SetActive(false);
    }
}
