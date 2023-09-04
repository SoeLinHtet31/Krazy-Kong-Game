using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarLocalScale : MonoBehaviour
{
    public Transform HealthBar;
    public GameObject Enemies;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Enemies.transform.localScale.x == 15)
        {
            HealthBar.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Enemies.transform.localScale.x == -15)
        {
            HealthBar.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
