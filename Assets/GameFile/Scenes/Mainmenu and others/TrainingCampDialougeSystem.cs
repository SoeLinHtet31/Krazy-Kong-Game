using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingCampDialougeSystem : MonoBehaviour
{
    public GameObject trainingCampDialouge;
    public Transform Plane;
    public GameObject Shop;
    public GameObject PlaneHolder;
    public GameObject Blocker3;

    public int TrainingCampDialouge;

    public Transform GameCityName;
    public GameObject TransportationPlane;

    private void Update()
    {
        TrainingCampDialouge = SceneManagement.ShowTraingCampDialouge;

        if (SceneManagement.ShowTraingCampDialouge == 2)
        {
            Blocker3.SetActive(true);
            trainingCampDialouge.SetActive(true);
            Plane.transform.SetParent(Shop.transform);
        }
        else if ( SceneManagement.ShowTraingCampDialouge > 2)
        {
            GameCityName.transform.SetParent(TransportationPlane.transform);
            Blocker3.SetActive(false);
            trainingCampDialouge.SetActive(false);
            Plane.transform.SetParent(PlaneHolder.transform);
   
        }
        if (SceneManagement.ShowTraingCampDialouge <= 1)
        {
            GameCityName.transform.SetParent(TransportationPlane.transform);
            Blocker3.SetActive(false);
            trainingCampDialouge.SetActive(false);
            Plane.transform.SetParent(PlaneHolder.transform);
        }
    }
    
}
