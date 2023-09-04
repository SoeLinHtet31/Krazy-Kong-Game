using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCamera : MonoBehaviour
{
    //Attach a new Camera in the Inspector window
    public Camera m_SecondCamera;
    //This is set as the main Camera in this script
    Camera m_FirstCamera;

    void Start()
    {
        //Disable the second Camera
        m_SecondCamera.enabled = false;
        //Set where to place the second Camera along with its width and height
        m_SecondCamera.pixelRect = new Rect(0, 0, 1920, 1080);
        //Set the first Camera as the main Camera
        m_FirstCamera = Camera.main;
    }

    void Update()
    {
        //Press the space key to toggle the second Camera and output camera pixel width and height
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Check if the second camera is enabled yet
            if (!m_SecondCamera.enabled)
            {
                //Toggle the second Camera and output the second Camera's details
                ToggleCamera(m_SecondCamera, m_SecondCamera);
            }
            else
            {
                //Toggle the second Camera and output the first Camera's details
                ToggleCamera(m_SecondCamera, m_FirstCamera);
            }
        }
    }

    //Toggle the Camera and output the Camera specified
    void ToggleCamera(Camera cameraToggle, Camera cameraOutput)
    {
        //Set Camera on and off
        cameraToggle.enabled = !cameraToggle.enabled;

        //Output the Camera's new Pixel width
        Debug.Log("Pixel width :" + cameraOutput.pixelWidth + " Pixel height : " + cameraOutput.pixelHeight);
    }
}
