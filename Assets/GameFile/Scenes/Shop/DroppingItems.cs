using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DroppingItems : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public int Numbers;

    public void RandomGenerate()
    {
        Numbers = Random.Range(1, 60);
        TextBox.text = "" + Numbers;
    }
}
