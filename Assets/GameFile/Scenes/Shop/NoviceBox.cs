using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoviceBox : MonoBehaviour
{
    public ShopNumberGenerator NumberGenerator1;

    public TextMeshProUGUI GeneratedNumber1;

    public Animator anim;

    public GameObject Open;

    public GameObject PrisonerKongShard;
    public GameObject BaseBallBatShard;
    public GameObject KongS;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(ShopSystem.NoviceBoxOpen == 0)
        {
            Open.SetActive(true);
        }
        else if (ShopSystem.NoviceBoxOpen < 0)
        {
            Open.SetActive(false);
        }
    }
    public void Drop()
    {
        NumberGenerator1.RandomGenerate();

        if((GeneratedNumber1.text == "1")|| (GeneratedNumber1.text == "5") || (GeneratedNumber1.text == "10") || (GeneratedNumber1.text == "15") || (GeneratedNumber1.text == "20") || (GeneratedNumber1.text == "25"))
        {
            PrisonerKongShard.SetActive(true);
            BaseBallBatShard.SetActive(false);
            KongS.SetActive(false);
            ItemsDropSystem.PrisonerKongShard += Random.Range(1, 2);
            PlayerPrefs.SetInt("PrisonerKongShard", ItemsDropSystem.PrisonerKongShard);
        }
        

        if ((GeneratedNumber1.text == "2") || (GeneratedNumber1.text == "6") || (GeneratedNumber1.text == "11") || (GeneratedNumber1.text == "16") || (GeneratedNumber1.text == "21") || (GeneratedNumber1.text == "26"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(true);
            KongS.SetActive(false);
            ItemsDropSystem.BaseBallShards += Random.Range(1, 2);
            PlayerPrefs.SetInt("BaseBallShards", ItemsDropSystem.BaseBallShards);
        }

        if ((GeneratedNumber1.text == "3") || (GeneratedNumber1.text == "4") || (GeneratedNumber1.text == "7") || (GeneratedNumber1.text == "8") || (GeneratedNumber1.text == "9") || (GeneratedNumber1.text == "12") || (GeneratedNumber1.text == "13")
            || (GeneratedNumber1.text == "14") || (GeneratedNumber1.text == "17") || (GeneratedNumber1.text == "18") || (GeneratedNumber1.text == "19") || (GeneratedNumber1.text == "22") || (GeneratedNumber1.text == "23") || (GeneratedNumber1.text == "24") || 
            (GeneratedNumber1.text == "27") || (GeneratedNumber1.text == "28") || (GeneratedNumber1.text == "29") || (GeneratedNumber1.text == "30"))
        {
            PrisonerKongShard.SetActive(false);
            BaseBallBatShard.SetActive(false);
            KongS.SetActive(true);
            PlayerMoney.numberOfCoin += 100;
            PlayerPrefs.SetInt("NumberOfCoin", PlayerMoney.numberOfCoin);
        }


        Open.SetActive(false);
        Invoke("Reset", 1.5f);

    }
    void Reset()
    {
        PrisonerKongShard.SetActive(false);
        BaseBallBatShard.SetActive(false);
        KongS.SetActive(false);
        anim.SetTrigger("Reset");
    }

    
}
