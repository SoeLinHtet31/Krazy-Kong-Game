using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTriggerVer2 : MonoBehaviour
{
    public GameObject Gate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            Gate.SetActive(true);
    }
}
