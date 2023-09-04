using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlOption : MonoBehaviour
{
    public GameObject Player;
    public Animator _player;
    public GameObject JoyStick;
    public GameObject mobielTrigger;

    public GameObject AttackButton;

    public AudioSource BatHit;
    public GameObject BaseBallBat;

    public GameObject _Stage1;
    public GameObject _Stage2;

    public GameObject LoadingPage;


    private void Start()
    {
        LoadingPage.SetActive(false);
        mobielTrigger.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && Time.timeScale == 1f || Input.GetKeyDown(KeyCode.A) && Time.timeScale == 1f)
        {
            PlayerMovement.PCMode += 1;
            FlameThrowerAction.PCMode += 1;
            FlameThrowerAttackSystem.PCMode += 1;
            FlameSystem.PCMode += 1;
            MachineGunAction.PCMode += 1;
            BaseBallBatAction.PCMode += 1;

            JoyStick.SetActive(false);
            Time.timeScale = 1f;
            AttackButton.SetActive(false);
        }

        if(Time.timeScale == 1)
        {
            if (PlayerMovement.PCMode >= 1f)
            {
                Player.GetComponent<PlayerMovement1>().enabled = false;
                Player.GetComponent<PlayerMovement>().enabled = true;
                Player.GetComponent<Jumpcontroller>().enabled = true;
                BaseBallBat.GetComponent<BaseBallBatAction>().enabled = true;
                BaseBallBat.GetComponent<BaseBallActionMobile>().enabled = false;
                mobielTrigger.SetActive(false);
            }

            if (PlayerMovement1.MobileMode >= 1)
            {
                Player.GetComponent<PlayerMovement1>().enabled = true;
                Player.GetComponent<PlayerMovement>().enabled = false;
                Player.GetComponent<Jumpcontroller>().enabled = true;
                BaseBallBat.GetComponent<BaseBallBatAction>().enabled = false;
                BaseBallBat.GetComponent<BaseBallActionMobile>().enabled = true;
            }
        }
        else if (Time.timeScale == 0f)
        {
            Player.GetComponent<PlayerMovement1>().enabled = false;
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<PlayerMovement>().moveLeft = false;
            Player.GetComponent<PlayerMovement>().moveRight = false;
            Player.GetComponent<PlayerMovement1>().moveLeft = false;
            Player.GetComponent<PlayerMovement1>().moveRight = false;
            Player.GetComponent<Jumpcontroller>().enabled = false;
            BaseBallBat.GetComponent<BaseBallBatAction>().enabled = false;
            BaseBallBat.GetComponent<BaseBallActionMobile>().enabled = false;
        }
    }

    

    public void HitSound()
    {
        BatHit.Play();
    }


    public void OnPointerDownToGoMobile()
    {
   
        PlayerMovement1.MobileMode += 1;
        BaseBallActionMobile.MobileMoode += 1;

        AttackButton.SetActive(true);
        mobielTrigger.SetActive(false);
        JoyStick.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Mainmenu()
    {        
        SceneManagement.ShowTraingCampDialouge -= 1;
        PlayerPrefs.SetInt("ShowTraingCampDialouge", SceneManagement.ShowTraingCampDialouge);
        LoadingPage.SetActive(true);
    }

    public void TransformToSecondStage()
    {
        LoadingPage.SetActive(true);
        _player.Play("Idle");
    }

    public void TransformToFirstStage()
    {
        LoadingPage.SetActive(true);
        _player.Play("Idle");
    }
}

