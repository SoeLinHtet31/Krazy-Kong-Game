using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemieHealthBar : MonoBehaviour
{
    [SerializeField] private EnemyHealth EnemyHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;


    private void Start()
    {
        totalHealthBar.fillAmount = EnemyHealth.currentHealth /100;
    }

    private void Update()
    {
        currentHealthBar.fillAmount = EnemyHealth.currentHealth /100;
    }






}
