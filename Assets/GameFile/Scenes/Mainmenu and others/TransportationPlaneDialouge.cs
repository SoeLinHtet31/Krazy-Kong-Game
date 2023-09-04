using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportationPlaneDialouge : MonoBehaviour
{
    public static int TransportationPlane;
    public GameObject transportationPlaneDialouge;

    public GameObject Blocker2;

    private void Awake()
    {
        TransportationPlane = PlayerPrefs.GetInt("TransportationPlane", 0);
    }
    private void Update()
    {
        if (TransportationPlane < 0)
        {
            transportationPlaneDialouge.SetActive(false);
            Blocker2.SetActive(false);
        }

    }
}
