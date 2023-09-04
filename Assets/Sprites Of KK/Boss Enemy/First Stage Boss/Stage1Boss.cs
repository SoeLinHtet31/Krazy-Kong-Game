using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Boss : MonoBehaviour
{
    public Transform player;
    public bool isFlipped = false;

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.position;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && !isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(10.81f, 11.67912f, 1f);
            isFlipped = true;
        }
        else if (transform.position.x < player.position.x && isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(-10.81f, 11.67912f, 1f);
            isFlipped = false;
        }
    }
}
