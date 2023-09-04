using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopNumberGenerator : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public int Numbers;

    public void RandomGenerate()
    {
        Numbers = Random.Range(1, 30);
        TextBox.text = "" + Numbers;
    }
}
