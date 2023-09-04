using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESUME : MonoBehaviour
{
    public GameObject PrizeSett;
    public GameObject PauseButt;

    private void OnMouseDown()
    {
        PauseButt.SetActive(true);
        PrizeSett.SetActive(false);
        Time.timeScale = 1f;
    }
}
