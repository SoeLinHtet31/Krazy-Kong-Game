using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomControl : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineCamera;
    public GameObject ZoomButton1;
    public GameObject ZoomButton2;

    public static int zoomControl;

    public int showZoomControl;
    private void Awake()
    {
        zoomControl = PlayerPrefs.GetInt("XoomControl", 0);
    }
    private void Start()
    {
        if (zoomControl == 0)
        {
            cinemachineCamera.m_Lens.OrthographicSize = 29.9f;
            ZoomButton2.SetActive(false);
            ZoomButton1.SetActive(true);
        }

        if (zoomControl == 1)
        {
            cinemachineCamera.m_Lens.OrthographicSize = 18f;
            ZoomButton1.SetActive(false);
            ZoomButton2.SetActive(true);
        }
    }

    private void Update()
    {
        if (zoomControl == 0)
        {
            cinemachineCamera.m_Lens.OrthographicSize = 29.9f;
            ZoomButton2.SetActive(false);
            ZoomButton1.SetActive(true);
        }

        if (zoomControl == 1)
        {
            cinemachineCamera.m_Lens.OrthographicSize = 18f;
            ZoomButton1.SetActive(false);
            ZoomButton2.SetActive(true);
        }

        showZoomControl = zoomControl;
    }

    public void ChangeZoomIn()
    {
        cinemachineCamera.m_Lens.OrthographicSize = 18f;
        ZoomButton1.SetActive(false);
        ZoomButton2.SetActive(true);
        zoomControl += 1;
        PlayerPrefs.SetInt("XoomControl", zoomControl);
    }

    public void ChangeZoomOut()
    {
        cinemachineCamera.m_Lens.OrthographicSize = 29.9f;
        ZoomButton2.SetActive(false);
        ZoomButton1.SetActive(true);
        zoomControl -= 1;
        PlayerPrefs.SetInt("XoomControl", zoomControl);
    }
}
