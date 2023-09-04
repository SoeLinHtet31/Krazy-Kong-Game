using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJoyStick : MonoBehaviour
{
    Vector2 move;
    public int speed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += new Vector3(move.x, move.y, 0) * speed * Time.deltaTime;

        transform.Translate(move * speed * Time.deltaTime);
    }
}
