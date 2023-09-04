using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeEnemieHealthBar : MonoBehaviour
{
    [SerializeField] private SecStageEneHealth EnemyHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;


    private void Start()
    {
        totalHealthBar.fillAmount = EnemyHealth.currentHealth / 250;
    }

    private void Update()
    {
        currentHealthBar.fillAmount = EnemyHealth.currentHealth / 250;
    }





}
