using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFromPayLine : MonoBehaviour
{
    public GameObject PayLines;
    public GameObject PrizeSet;
    public GameObject BackButtom;
    public GameObject resumeButton;

    private void OnMouseDown()
    {
        resumeButton.SetActive(true);
        PayLines.SetActive(false);
        PrizeSet.SetActive(true);
        BackButtom.SetActive(false);
        Time.timeScale = 0f;
    }
}
