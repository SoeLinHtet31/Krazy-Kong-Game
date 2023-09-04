using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSystem : MonoBehaviour
{
    public static int PrisonerKongAmount;

    public TextMeshProUGUI prisonerKongAmount;

    public void Awake()
    {
        PrisonerKongAmount = PlayerPrefs.GetInt("PrisonerKongAmount", 1);
        prisonerKongAmount.text = PrisonerKongAmount.ToString();
    }
}
