using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausemenuTrigger : MonoBehaviour
{
    public GameObject PaauseMenu;
    public GameObject PauseMenuTrigger;

    private void OnMouseDown()
    {
        PaauseMenu.SetActive(true);
        PauseMenuTrigger.SetActive(false);
        Time.timeScale = 0f;
    }
}
