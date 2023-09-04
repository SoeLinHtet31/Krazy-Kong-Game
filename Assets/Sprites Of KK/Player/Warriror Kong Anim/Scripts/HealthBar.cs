using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public PrisonerKongData PrisonerKong;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    public TextMeshProUGUI fullHealth;
    public TextMeshProUGUI currentHealth;

    private void Start()
    {

    }

    private void Update()
    {
        totalHealthBar.fillAmount = (float)PrisonerKongData.startingHealth;
        fullHealth.text = PrisonerKongData.startingHealth.ToString();
        currentHealthBar.fillAmount = (float)PrisonerKongData.curentHealth / (float)PrisonerKongData.startingHealth;
        currentHealth.text = PrisonerKongData.curentHealth.ToString();
        if (PrisonerKongData.curentHealth <= 0)
        {
            currentHealth.text = "0";
        }
    }






}
