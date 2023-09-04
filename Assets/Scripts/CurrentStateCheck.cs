using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentStateCheck : MonoBehaviour
{
    public TextMeshProUGUI PrisonerKongHealth;
    public TextMeshProUGUI PrisonerKongMoveSpeed;
    public TextMeshProUGUI PrisonerKongSKYBITGain;

    public TextMeshProUGUI BaseBallBatDamage;
    public TextMeshProUGUI BaseBallBatAttackSpeed;
    public TextMeshProUGUI BaseBallBatAttackCooldown;

    private void Update()
    {
        PrisonerKongHealth.text = PrisonerKongData.PrisonerKongHealth.ToString();
        PrisonerKongMoveSpeed.text = PrisonerKongData.PrisonerKongSpeed.ToString();
        PrisonerKongSKYBITGain.text = SKYBITToken.SkyBitTokengainAmount.ToString();

        BaseBallBatDamage.text = BaseBallBatData.Damage.ToString();
        BaseBallBatAttackSpeed.text = BaseBallBatData.AttackSpeed.ToString();
        BaseBallBatAttackCooldown.text = BaseBallBatData.Cooldown.ToString();
    }
}
