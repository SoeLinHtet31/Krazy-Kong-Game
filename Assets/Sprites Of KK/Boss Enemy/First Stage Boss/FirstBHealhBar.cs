using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstBHealhBar : MonoBehaviour
{
    [SerializeField] private BossHealth BossHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {
        totalHealthBar.fillAmount = BossHealth.currentHealth / 250;
    }

    private void Update()
    {
        currentHealthBar.fillAmount = BossHealth.currentHealth / 250;
    }
}
