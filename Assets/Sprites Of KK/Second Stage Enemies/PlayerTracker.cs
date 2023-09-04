using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public GameObject SittingPlace;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SittingPlace.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SittingPlace.SetActive(true);
    }
}
