using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPotion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            PrisonerKongData.experience += Random.Range(5, 10);
            PlayerPrefs.SetInt("PrisonerKongExp", PrisonerKongData.experience);

         

            gameObject.SetActive(false);
        }
    }
}
