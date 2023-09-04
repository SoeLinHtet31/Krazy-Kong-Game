using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerShard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            ItemsDropSystem.FlameThrowerWeaponShards += Random.Range(1, 2);
            PlayerPrefs.SetInt("FlameThrowerWeaponShards", ItemsDropSystem.FlameThrowerWeaponShards);


            gameObject.SetActive(false);
        }
    }
}
