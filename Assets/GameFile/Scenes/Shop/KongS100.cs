using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KongS100 : MonoBehaviour
{
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerMoney.numberOfCoin += 100;
            PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
            gameObject.SetActive(false);
            transform.position = startPosition;
        }
    }
}
