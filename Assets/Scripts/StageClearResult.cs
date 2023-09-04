using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StageClearResult : MonoBehaviour
{
    public static StageClearResult instance;

    public GameObject Player;
    public Transform Stage1;
    public Transform Stage2;

    public Transform _Player;
    public Rigidbody2D player;
    public GameObject Rty1;
    public GameObject Rty2;

    public GameObject SkybitGainAmount1;
    public GameObject SkybitGainAmount2;

    public GameObject BaseBallBat;

    public GameObject clearResult;
    public Gate gate1;

    public GameObject pauseMenu;
    public GameObject MobileButtonTrigger;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {



    }

    private void Update()
    {
        if (PlayerCondition.StageAmount == 1)
        {
            SkybitGainAmount1.SetActive(true);
            SkybitGainAmount2.SetActive(false);
            Rty1.SetActive(true);
            Rty2.SetActive(false);
        }
        else if (PlayerCondition.StageAmount == 2)
        {
            SkybitGainAmount1.SetActive(false);
            SkybitGainAmount2.SetActive(true);
            Rty1.SetActive(false);
            Rty2.SetActive(true);
        }
    }
    public void EnableStageResult()
    {
        clearResult.SetActive(true);
        Time.timeScale = 0f;
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        
    }

    public void ExitFromStageClear()
    {
        clearResult.SetActive(false);
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        Time.timeScale = 1f;
    }
    public void Retry()
    {
        pauseMenu.SetActive(false);
        clearResult.SetActive(false);
        Time.timeScale = 1f;
        _Player.transform.position = Stage1.position;
        gate1.OpenDoor();

    }
    public void Retry2()
    {
        pauseMenu.SetActive(false);
        clearResult.SetActive(false);
        Time.timeScale = 1f;
        _Player.transform.position = Stage2.position;
        gate1.OpenDoor();
    }
}
