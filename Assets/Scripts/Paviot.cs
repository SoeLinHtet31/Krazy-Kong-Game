using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paviot : MonoBehaviour
{
    public GameObject myPlayer;


    private void FixedUpdate()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if (myPlayer.transform.eulerAngles.y == 0 && rotationZ < -90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -rotationZ);

        }
        else if (myPlayer.transform.eulerAngles.y == 180 && rotationZ > 270 && rotationZ < 90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, rotationZ);
        }


        if (rotationZ > 90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -rotationZ);
        }
        else if (rotationZ < -90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -rotationZ);
        }


    }
}