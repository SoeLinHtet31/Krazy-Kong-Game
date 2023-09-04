using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public GameObject Bullets;
    public Transform Effects;
    public GameObject Effect;

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Effect.SetActive(true);
            Effects.transform.position = Bullets.transform.position;
        }
  

        


    }

}
