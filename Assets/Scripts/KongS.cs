using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KongS : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            PlayerMoney.numberOfCoin += Random.Range(5, 10);
            PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
            gameObject.SetActive(false);
            Invoke("reset", 3600f);
        }
    }
    private void reset()
    {
        gameObject.SetActive(true);
    }
}
