using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausesetting : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public GameObject PauseButton;

    public GameObject ChracterHB;
    public GameObject ChracterHealthBar;

    public GameObject UpgradePage;
    public GameObject Canvas1;

    public GameObject StateCheckPanel;

    public GameObject Player;

    public Rigidbody2D player;

    public GameObject Setting;

    public GameObject BaseBallBat;
    public GameObject MachineGun;
    public GameObject FlameThrower;
    public GameObject Flame;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            ChracterHB.SetActive(false);
            ChracterHealthBar.SetActive(false);
            player.constraints = RigidbodyConstraints2D.FreezeAll;
            PauseButton.SetActive(false);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Pause()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;

        PauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

        ChracterHB.SetActive(false);
        ChracterHealthBar.SetActive(false);
    }


    public void Resume()
    {      
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        ChracterHB.SetActive(true);
        ChracterHealthBar.SetActive(true);

        PauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Mainmenu(int sceneID)
    {
        SceneManagement.ShowTraingCampDialouge += 1;
        PlayerPrefs.SetInt("showTraingCampDialouge", SceneManagement.ShowTraingCampDialouge);

        PauseButton.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void setting()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        Setting.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 0f;
    }

    public void exitFromSetting()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        Setting.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void StateShowBeforeGoToUpgradePage()
    {
        StateCheckPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitFromStateCheck()
    {
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        StateCheckPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GotoUpgradePage()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        UpgradePage.SetActive(true);
        Time.timeScale = 0f;
        Canvas1.SetActive(false);
    }

    public void ComeFromUpgradePage()
    {
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        StateCheckPanel.SetActive(false);
        Canvas1.SetActive(true);
        UpgradePage.SetActive(false);
        Time.timeScale = 1f;
    }
}
    
