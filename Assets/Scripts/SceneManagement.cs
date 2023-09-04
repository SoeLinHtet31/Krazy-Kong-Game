using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static int ShowTraingCampDialouge;

    private void Awake()
    {
        ShowTraingCampDialouge = PlayerPrefs.GetInt("showTraingCampDialouge", 0);
    }

    private void Update()
    {
        
    }

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void MoveToADvanture(int sceneID)
    {
        TransportationPlaneDialouge.TransportationPlane -= 1;
        PlayerPrefs.SetInt("TransportationPlane", TransportationPlaneDialouge.TransportationPlane);

        ShowTraingCampDialouge += 1;
        PlayerPrefs.SetInt("showTraingCampDialouge", ShowTraingCampDialouge);

        SceneManager.LoadScene(sceneID);
    }

    public void BackToMainMenu(int sceneID)
    {
        ShowTraingCampDialouge += 1;
        PlayerPrefs.SetInt("showTraingCampDialouge", ShowTraingCampDialouge);
        SceneManager.LoadScene(sceneID);
    }

    public void ComeFromTrainingCamp(int sceneID)
    {
        ShowTraingCampDialouge += 5;
        PlayerPrefs.SetInt("showTraingCampDialouge", ShowTraingCampDialouge);
        SceneManager.LoadScene(sceneID);
    }
}
