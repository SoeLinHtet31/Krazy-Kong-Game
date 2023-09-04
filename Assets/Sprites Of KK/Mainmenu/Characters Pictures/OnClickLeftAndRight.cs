using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickLeftAndRight : MonoBehaviour
{
    public GameObject Clicker;
    public GameObject Clicker2;
    public GameObject Clicker3;

    public GameObject Clicker4;
    public GameObject Clicker5;
    public GameObject Clicker6;

    public GameObject MichealKongSelect;
    public GameObject PimpKongSelect;

    private void Update()
    {
        if(AmountOFNFTHOLD.amountOfFirstKrazyKongNFt > 0)
        {
            MichealKongSelect.SetActive(true);
            PimpKongSelect.SetActive(true);
        }
        else if (AmountOFNFTHOLD.amountOfFirstKrazyKongNFt <= 0)
        {
            MichealKongSelect.SetActive(false);
            PimpKongSelect.SetActive(false);
        }
    }

    public Animator CharacterSelection;


    public void ChangeChar1()
    {
        CharacterSelection.SetTrigger("MichealKong");
        Clicker.SetActive(false);
        Clicker2.SetActive(true);
        Clicker4.SetActive(false);
        Clicker5.SetActive(true);
    }
    public void ChangeChar2()
    {
        CharacterSelection.SetTrigger("PimpKong");
        Clicker2.SetActive(false);
        Clicker3.SetActive(true);
        Clicker5.SetActive(false);
        Clicker6.SetActive(true);
    }
    public void ChangeChar3()
    {
        CharacterSelection.SetTrigger("PrisonerKong");
        Clicker3.SetActive(false);
        Clicker.SetActive(true);
        Clicker6.SetActive(false);
        Clicker5.SetActive(true);
    }

    public void ChangeChar21()
    {
        CharacterSelection.SetTrigger("PimpKong");
        Clicker.SetActive(false);
        Clicker3.SetActive(true);
        Clicker4.SetActive(false);
        Clicker6.SetActive(true);
    }
    public void ChangeChar22()
    {
        CharacterSelection.SetTrigger("MichealKong");
        Clicker3.SetActive(false);
        Clicker2.SetActive(true);
        Clicker6.SetActive(false);
        Clicker5.SetActive(true);
    }
    public void ChangeChar23()
    {
        CharacterSelection.SetTrigger("PrisonerKong");
        Clicker2.SetActive(false);
        Clicker.SetActive(true);
        Clicker5.SetActive(false);
        Clicker4.SetActive(true);
    }
}
