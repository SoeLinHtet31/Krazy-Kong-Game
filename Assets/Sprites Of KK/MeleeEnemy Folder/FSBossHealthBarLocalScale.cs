using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSBossHealthBarLocalScale : MonoBehaviour
{
    public Transform HealthBar;
    public GameObject boss;
    public bool isFlipped = false;



    private void FixedUpdate()
    {
        if (boss.transform.localScale.x == 10.81f && !isFlipped)
        {
            HealthBar.transform.localScale = new Vector3(1, 1, 1);
            isFlipped = true;
        }
        else if (boss.transform.localScale.x == -10.81f && isFlipped)
        {
            HealthBar.transform.localScale = new Vector3(-1, 1, 1);
            isFlipped = false;
        }
    }
}
