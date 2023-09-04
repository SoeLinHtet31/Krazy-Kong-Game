using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D box;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Player")
            Invoke ("DropPlatform", 0.8f);
        Destroy(gameObject, 1f);
    }

    void DropPlatform()
    {

        rb.isKinematic = false;
        box.enabled = false;
    }

} 
