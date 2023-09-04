using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetection : MonoBehaviour
{
    public GameObject BaseBallBat;

   

    void OnMouseOver()
    {

        BaseBallBat.GetComponent<BaseBallBatAction>().enabled = false;
        



    }

    void OnMouseExit()
    {
        BaseBallBat.GetComponent<BaseBallBatAction>().enabled = true;
 

        
    }
}
