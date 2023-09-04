using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    CapsuleCollider2D box;
    private float lifetime;
    [SerializeField] private float resetTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<CapsuleCollider2D>();
    }

    private void Update()
    {
        lifetime += Time.deltaTime;
        if (lifetime > resetTime) gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Player")
            Invoke("DropPlatform", 0.8f);
        Destroy(gameObject, 1f);
    }

    void DropPlatform()
    {

        rb.isKinematic = false;
        box.enabled = false;
    }

}
