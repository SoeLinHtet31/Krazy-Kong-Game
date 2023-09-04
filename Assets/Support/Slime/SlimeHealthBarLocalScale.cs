using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealthBarLocalScale : MonoBehaviour
{
    public Transform HealthBar;
    public GameObject Enemies;

    private void Start()
    {

    }
    private void Update()
    {
        if (Enemies.transform.localScale.x == 39)
        {
            HealthBar.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Enemies.transform.localScale.x == -39)
        {
            HealthBar.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
