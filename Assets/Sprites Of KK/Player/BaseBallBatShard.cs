using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBallBatShard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            ItemsDropSystem.BaseBallShards += Random.Range(1, 2);
            PlayerPrefs.SetInt("BaseBallShards", ItemsDropSystem.BaseBallShards);


            gameObject.SetActive(false);
        }
    }
}
