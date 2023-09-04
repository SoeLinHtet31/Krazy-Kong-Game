using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfkDetection : MonoBehaviour
{
    public GameObject Player;
    public float time = Mathf.Infinity;

    private void Update()
    {
        if(Input.touchCount <= 0)
        {
            time += Time.deltaTime;
        }

        if (time > 10)
        {
            time = 0f;
            Player.SetActive(false);
            Invoke("ReActive", 0.005f);
        }
    }

    public void ReActive()
    {
        Player.SetActive(true);
    }
}
