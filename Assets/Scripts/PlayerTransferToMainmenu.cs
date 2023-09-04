using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransferToMainmenu : MonoBehaviour
{
    public Transform Player;
    public GameObject _transformPlace;
    public Animator _Player;
    //Weapon
    public GameObject _BaseBallBat;
    public Rigidbody2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerCondition.StageAmount = 0;
            player.GetComponent<Jumpcontroller>().enabled = false;
            SceneManagement.ShowTraingCampDialouge += 1;
            PlayerPrefs.SetInt("showTraingCampDialouge", SceneManagement.ShowTraingCampDialouge);
            Player.transform.position = _transformPlace.transform.position;
            _Player.SetTrigger("Transform");
            player.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    

}
