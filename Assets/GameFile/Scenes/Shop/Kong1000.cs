using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kong1000 : MonoBehaviour
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
        if (collision.tag == "Player")
        {
            KongSShop.BuyKongS += 1;
            PlayerMoney.numberOfCoin += 1000;
            PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
            gameObject.SetActive(false);
            transform.position = startPosition;
        }
    }
}
