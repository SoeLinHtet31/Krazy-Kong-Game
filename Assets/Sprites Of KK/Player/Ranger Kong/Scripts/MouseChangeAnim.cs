using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChangeAnim : MonoBehaviour
{
    [SerializeField] Camera Maincamera;


    private void Start()
    {
    }


    private void Update()
    {
        Vector3 mouseWorldPosition = Maincamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
