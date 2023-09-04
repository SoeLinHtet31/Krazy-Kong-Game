using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Betlimitation : MonoBehaviour
{
    public GameObject Betbutton;

    private void Update()
    {
        if (SKYBITToken.SkybitToken <= 99)
        {
            Betbutton.SetActive(false);
        }
        if (SKYBITToken.SkybitToken >= 100)
        {
            Betbutton.SetActive(true);
        }
    }

}
