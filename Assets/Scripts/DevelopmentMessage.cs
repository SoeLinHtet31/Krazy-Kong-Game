using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevelopmentMessage : MonoBehaviour
{
    public GameObject DevelopmentMesssage;

    public void ONClick()
    {
        DevelopmentMesssage.SetActive(true);
        Invoke("Disable", 5f);
    }

    void Disable()
    {
        DevelopmentMesssage.SetActive(false);
    }
}
