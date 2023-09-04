using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecStagBHelathBar : MonoBehaviour
{
    [SerializeField] private SecondStageBossHealth BossHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {

    }

    private void Update()
    {
        currentHealthBar.fillAmount = BossHealth.currentHealth / 1000;
    }
}
