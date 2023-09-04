using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public Animator WeaponSelectionHolder;

    public GameObject WeaponSelection;

    public GameObject Intruction;
    public GameObject Intruction2;

    public GameObject Setting;
    public GameObject SettingTrigger;

    Vector3 position;

    public GameObject Right1;
    public GameObject Right2;
    public GameObject Right3;
    public GameObject Right4;


    public GameObject Left1;
    public GameObject Left2;
    public GameObject Left3;
    public GameObject Left4;

    public GameObject PlayerBaseBallBat;
    public GameObject PlayerMachineGun;
    public GameObject PlayerFlameThrower;
    public GameObject PlayerGozillzHead;

    public GameObject PictureBaseBallBat;
    public GameObject PictureMachineGun;
    public GameObject PictureFlameThrower;
    public GameObject PictureGozillzHead;

    public GameObject BaseBallBat;
    public GameObject MachineGun;
    public GameObject FlameThrower;
    public GameObject GozillzHead;

    public PlayerData Player;

    public MachineGunAction MachineGuns;

    public MachineGunData Machine;

    public GameObject Flame;

    public GameObject BaseBallAttackButton;
    public GameObject MachineGunAttackButton;
    public GameObject FlameThrowerAttackButton;

    public GameObject player;


    private void Awake()
    {
        WeaponSelection.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        //Weapon Show in Battle
        if (Player.BaseBallBatEquipedAmount >= 1)
        {
            PlayerBaseBallBat.SetActive(true);
            BaseBallAttackButton.SetActive(true);
        }
        else if (Player.BaseBallBatEquipedAmount <= 0)
        {
            PlayerBaseBallBat.SetActive(false);
            BaseBallAttackButton.SetActive(false);
        }

        if (Player.MachineGunEquipedAmount >= 1)
        {
            PlayerMachineGun.SetActive(true);
            MachineGunAttackButton.SetActive(true);
        }
        else if (Player.MachineGunEquipedAmount <= 0)
        {
            PlayerMachineGun.SetActive(false);
            MachineGunAttackButton.SetActive(false);
        }

        if (Player.FlameThrowerEquipedAmount >= 1)
        {
            PlayerFlameThrower.SetActive(true);
            Flame.SetActive(true);
            FlameThrowerAttackButton.SetActive(true);
        }
        else if (Player.FlameThrowerEquipedAmount <= 0)
        {
            PlayerFlameThrower.SetActive(false);
            Flame.SetActive(false);
            FlameThrowerAttackButton.SetActive(false);
        }

        if (Player.GozillaHeadEquipedAmount >= 1)
        {
            PlayerGozillzHead.SetActive(true);
        }
        else if (Player.GozillaHeadEquipedAmount <= 0)
        {
            PlayerGozillzHead.SetActive(false);
        }


        //Weapon Show in Selection
        if (PlayerData.BaseBallBatAmount >= 1)
        {
            BaseBallBat.SetActive(true);
        }
        else if (PlayerData.BaseBallBatAmount <= 0)
        {
            BaseBallBat.SetActive(false);
        }

        if (PlayerData.MachineGunAmount >= 1)
        {
            MachineGun.SetActive(true);
        }
        else if (PlayerData.MachineGunAmount <= 0)
        {
            MachineGun.SetActive(false);
        }

        if (PlayerData.FlameThrowerAmount >= 1)
        {
            FlameThrower.SetActive(true);
        }
        else if (PlayerData.FlameThrowerAmount <= 0)
        {
            FlameThrower.SetActive(false);
        }

        if (PlayerData.GozillaHeadAmount >= 1)
        {
            GozillzHead.SetActive(true);
        }
        else if (PlayerData.GozillaHeadAmount <= 0)
        {
            GozillzHead.SetActive(false);
        }
    }

    public void Right()
    {
        WeaponSelectionHolder.SetTrigger("+2000");
        PictureBaseBallBat.SetActive(false);
        PictureMachineGun.SetActive(true);

        Right1.SetActive(false);
        Right2.SetActive(true);

        Left1.SetActive(false);
        Left4.SetActive(true);



    }
    public void Right02()
    {
        WeaponSelectionHolder.SetTrigger("+4000");
        PictureMachineGun.SetActive(false);
        PictureFlameThrower.SetActive(true);

        Right2.SetActive(false);
        Right3.SetActive(true);

        Left4.SetActive(false);
        Left3.SetActive(true);

    }
    public void Right03()
    {
        WeaponSelectionHolder.SetTrigger("+6000");

        PictureFlameThrower.SetActive(false);
        PictureGozillzHead.SetActive(true);

        Right3.SetActive(false);
        Right4.SetActive(true);

        Left3.SetActive(false);
        Left2.SetActive(true);

    }

    public void Right04()
    {
        WeaponSelectionHolder.SetTrigger("0000");

        PictureGozillzHead.SetActive(false);
        PictureBaseBallBat.SetActive(true);

        Right4.SetActive(false);
        Right1.SetActive(true);

        Left2.SetActive(false);
        Left1.SetActive(true);

    }


    public void Left01()
    {
        WeaponSelectionHolder.SetTrigger("+6000");

        PictureBaseBallBat.SetActive(false);
        PictureGozillzHead.SetActive(true);

        Right1.SetActive(false);
        Right4.SetActive(true);

        Left1.SetActive(false);
        Left2.SetActive(true);

    }
    public void Left02()
    {
        WeaponSelectionHolder.SetTrigger("+4000");

        PictureGozillzHead.SetActive(false);
        PictureFlameThrower.SetActive(true);

        Right4.SetActive(false);
        Right3.SetActive(true);

        Left2.SetActive(false);
        Left3.SetActive(true);

    }
    public void Left03()
    {
        WeaponSelectionHolder.SetTrigger("+2000");

        PictureFlameThrower.SetActive(false);
        PictureMachineGun.SetActive(true);

        Right3.SetActive(false);
        Right2.SetActive(true);

        Left3.SetActive(false);
        Left4.SetActive(true);

    }

    public void Left04()
    {
        WeaponSelectionHolder.SetTrigger("0000");

        PictureMachineGun.SetActive(false);
        PictureBaseBallBat.SetActive(true);

        Right2.SetActive(false);
        Right1.SetActive(true);

        Left4.SetActive(false);
        Left1.SetActive(true);

    }




    public void SelectBaseBallBat()
    {
        
        Player.BaseBallBatEquipedAmount += 1;
        WeaponSelection.SetActive(false);
        if(TutorialMessage.tutorialMessage == 0)
        {
            Intruction.SetActive(true);
        }
        else if (TutorialMessage.tutorialMessage < 0)
        {
            Time.timeScale = 1f;
        }

    }

    public void SelectMachineGun()
    {
        
        Player.MachineGunEquipedAmount += 1;
        if (TutorialMessage.tutorialMessage == 0)
        {
            Intruction.SetActive(true);
        }
        else if (TutorialMessage.tutorialMessage < 0)
        {
            Time.timeScale = 1f;
        }
        WeaponSelection.SetActive(false);

    }

    public void SelectFlameThrower()
    {
        
        Player.FlameThrowerEquipedAmount += 1;
        if (TutorialMessage.tutorialMessage == 0)
        {
            Intruction.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (TutorialMessage.tutorialMessage < 0)
        {
            Time.timeScale = 1f;
        }

        WeaponSelection.SetActive(false);
    }

    public void SelectGozillaHead()
    {
        Player.GozillaHeadEquipedAmount += 1;
        WeaponSelection.SetActive(false);
        Time.timeScale = 0f;
    }

    public void instrationoff()
    {
        Intruction.SetActive(false);
        Intruction2.SetActive(true);
    }

    public void instrationoff2()
    {
        Intruction2.SetActive(false);
        TutorialMessage.tutorialMessage -= 1;
        PlayerPrefs.SetInt("tutorialMessage", TutorialMessage.tutorialMessage);
        Time.timeScale = 1f;
        player.GetComponent<PlayerControlOption>().enabled = true;
        if (PlayerMovement.PCMode >= 1)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (BaseBallBatAction.PCMode >= 1)
        {
            BaseBallBat.GetComponent<BaseBallBatAction>().enabled = true;
        }

        Player.GetComponent<Jumpcontroller>().enabled = true;

        if (PlayerMovement1.MobileMode >= 1)
        {
            player.GetComponent<PlayerMovement1>().enabled = true;
        }

        if (BaseBallBatAction.PCMode >= 1)
        {
            BaseBallBat.GetComponent<BaseBallBatAction>().enabled = true;
        }

        if (BaseBallActionMobile.MobileMoode >= 1)
        {
            BaseBallBat.GetComponent<BaseBallActionMobile>().enabled = true;
        }
    }

    public void GotoInstruction()
    {
        Intruction.SetActive(true);
        Time.timeScale = 0f;
        Setting.SetActive(false);
        SettingTrigger.SetActive(true);
    }
}
