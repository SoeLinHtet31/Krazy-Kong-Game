using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSettingForSlotGame : MonoBehaviour
{

    public Canvas cavs;
    [SerializeField] GameObject pauseMenu;
    public GameObject Prizesetting;

    public void ToPrizeSetting()
    {
        pauseMenu.SetActive(false);
        Prizesetting.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        cavs.sortingLayerName = "ForeGround";
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Mainmenu(int sceneID)
    {
        SceneManagement.ShowTraingCampDialouge -= 1;
        PlayerPrefs.SetInt("ShowTraingCampDialouge", SceneManagement.ShowTraingCampDialouge);

        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
