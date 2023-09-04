using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOvermenu : MonoBehaviour
{
   
    public GameObject gameOverMenu;
    [SerializeField] public Transform _player;
    [SerializeField] public Transform Stage1;
    public Transform Stage2;

    public Rigidbody2D player;
    public GameObject Player;
    public GameObject BaseBallBat;
    public GameObject MobileButtonTrigger;

    public GameObject Pausemenu;

    public GameObject retry1;
    public GameObject retry2;

    [SerializeField] public PrisonerKongData playerHealth;

    private void Awake()
    {
    }

    private void Update()
    {
        if (PlayerCondition.StageAmount == 1)
        {
            retry1.SetActive(true);
            retry2.SetActive(false);
        }
        else if(PlayerCondition.StageAmount == 2)
        {
            retry1.SetActive(false);
            retry2.SetActive(true);
        }
    }


    public void EnableGameOverMenu()
    {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        gameOverMenu.SetActive(true);
        Pausemenu.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        Pausemenu.SetActive(false);
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        _player.transform.position = Stage1.position;
        playerHealth.Respawn();
    }
    public void Mainmenu(int sceneID)
    {
        SceneManagement.ShowTraingCampDialouge += 1;
        PlayerPrefs.SetInt("showTraingCampDialouge", SceneManagement.ShowTraingCampDialouge);

        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
    public void Retry2()
    {
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
        gameOverMenu.SetActive(false);
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        _player.transform.position = Stage2.position;
        playerHealth.Respawn();
    }
}
