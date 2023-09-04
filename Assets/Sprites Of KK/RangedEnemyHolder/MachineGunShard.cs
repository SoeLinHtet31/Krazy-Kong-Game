using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunShard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            ItemsDropSystem.MachineGunShards += Random.Range(1, 2);
            PlayerPrefs.SetInt("MachineGunShards", ItemsDropSystem.MachineGunShards);


            gameObject.SetActive(false);
        }
    }
}
