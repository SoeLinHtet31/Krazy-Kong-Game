using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2BossHealthBarLocalScale : MonoBehaviour
{
    public GameObject Boss;
    public bool isFlipped = false;
    public Image currentHealth;

    private void FixedUpdate()
    {
        if (Boss.transform.localScale.x == -1.275711f && !isFlipped)
        {
            currentHealth.fillOrigin = (int)Image.OriginHorizontal.Right;
            isFlipped = true;
        }
        else if (Boss.transform.localScale.x == 1.275711f && isFlipped)
        {
            currentHealth.fillOrigin = (int)Image.OriginHorizontal.Left;
            isFlipped = false;
        }
    }
}
