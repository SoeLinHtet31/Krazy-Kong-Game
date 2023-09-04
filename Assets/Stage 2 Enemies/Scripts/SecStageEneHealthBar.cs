using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecStageEneHealthBar : MonoBehaviour
{
    [SerializeField] private SecStageEneHealth EnemyHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;


    private void Start()
    {
        totalHealthBar.fillAmount = EnemyHealth.currentHealth / 200;
    }

    private void Update()
    {
        currentHealthBar.fillAmount = EnemyHealth.currentHealth / 200;
    }






}
