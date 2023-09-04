using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichealKongShard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            ItemsDropSystem.MichealKongShards += Random.Range(1, 2);
            PlayerPrefs.SetInt("MichealKongShards", ItemsDropSystem.MichealKongShards);


            gameObject.SetActive(false);
        }
    }
}
