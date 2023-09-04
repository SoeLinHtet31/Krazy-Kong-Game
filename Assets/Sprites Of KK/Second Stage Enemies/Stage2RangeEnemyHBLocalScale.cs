using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2RangeEnemyHBLocalScale : MonoBehaviour
{
    public bool isFlipped = false;
    public Transform HealthBar;
    public GameObject enemy;

    private void FixedUpdate()
    {
        if (enemy.transform.localScale.x == -1 && !isFlipped)
        {
            transform.localScale = new Vector3(11f, 11f, 1f);
            HealthBar.transform.localScale = new Vector3(-11, 11, 1);
            isFlipped = true;
        }
        else if (enemy.transform.localScale.x == 1 && isFlipped)
        {
            transform.localScale = new Vector3(11f, 11f, 1f);
            HealthBar.transform.localScale = new Vector3(11, 11, 1);
            isFlipped = false;
        }
    }
}
