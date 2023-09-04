using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomToPayLine : MonoBehaviour
{
    public GameObject PayLiness;
    public GameObject PrizeSettings;
    public GameObject BackButtom;
    public GameObject ToButtoms;

    private void OnMouseDown()
    {
        PayLiness.SetActive(true);
        PrizeSettings.SetActive(false);
        BackButtom.SetActive(true);
        ToButtoms.SetActive(false);
        Time.timeScale = 0f;
    }
}

