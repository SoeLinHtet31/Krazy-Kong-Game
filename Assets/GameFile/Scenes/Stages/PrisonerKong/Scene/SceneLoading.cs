using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public Transform Player;
    public GameObject Stage1StartingPlace;
    public GameObject Stage2StartingPlace;
    public Image loadingFillBar;
    public GameObject LoadingPage;
    public float waitTime = 3f;
    public PlayerCondition _playerCon;
    public bool coolingDown;

    private void Start()
    {
        loadingFillBar.fillAmount = 0f;
    }
    public void GoToStage2()
    {
        Player.transform.position = Stage2StartingPlace.transform.position;
        Time.timeScale = 1f;
    }

    public void GoToStage1()
    {
        Player.transform.position = Stage1StartingPlace.transform.position;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if(loadingFillBar.fillAmount == 1 && _playerCon.ShowStageAmount == 1)
        {
            Time.timeScale = 0f;
            loadingFillBar.fillAmount = 0f;
            GoToStage2();
            LoadingPage.SetActive(false);
        }
        else if(loadingFillBar.fillAmount == 1 && _playerCon.ShowStageAmount == 2)
        {
            Time.timeScale = 0f;
            loadingFillBar.fillAmount = 0f;
            GoToStage1();
            LoadingPage.SetActive(false);
        }
        else if (loadingFillBar.fillAmount == 1 && _playerCon.ShowStageAmount == 0)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene(1);
        }

        loadingFillBar.fillAmount += 1.0f / waitTime * Time.deltaTime;

    }
}
