using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    Vector2 move;
    public int speed;


    private void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += new Vector3(move.x,0f,0f) * speed * Time.deltaTime;

        transform.Translate(move * speed * Time.deltaTime);
    }

}
