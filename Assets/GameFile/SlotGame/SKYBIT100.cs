using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKYBIT100 : MonoBehaviour
{
    private Animator anim;

    public GameObject Coindropper;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SKYBITToken.SkybitToken += 100;
            anim.SetTrigger("Deactivate");
            PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);

        }
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
        transform.position = Coindropper.transform.position;
    }
}
