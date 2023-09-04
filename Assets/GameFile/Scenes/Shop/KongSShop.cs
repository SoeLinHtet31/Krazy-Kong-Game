using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KongSShop : MonoBehaviour
{
    public GameObject Collect500KongSButton;
    public GameObject buy2500KongS;
    public GameObject buy5000KongS;

    public static int BuyKongS;
    public int ShowButKongS;



    public int Kong500Show;

    public GameObject KongS1001;
    public GameObject KongS1002;
    public GameObject KongS1003;
    public GameObject KongS1004;
    public GameObject KongS1005;

    public GameObject KongS5001;
    public GameObject KongS5002;
    public GameObject KongS5003;
    public GameObject KongS5004;
    public GameObject KongS5005;

    public GameObject KongS10001;
    public GameObject KongS10002;
    public GameObject KongS10003;
    public GameObject KongS10004;
    public GameObject KongS10005;

    private void Start()
    {
        BuyKongS = 0;
    }
    private void Update()
    {
        Kong500Show = ShopSystem.Kong500Open;
        ShowButKongS = BuyKongS;
        if (ShopSystem.Kong500Open == 0)
        {
            Collect500KongSButton.SetActive(true);
        }
        else if (ShopSystem.Kong500Open < 0)
        {
            Collect500KongSButton.SetActive(false);
        }

        if (SKYBITToken.SkybitToken >= 1000 && BuyKongS == 0)
        {
            buy2500KongS.SetActive(true);
        }
        else if (SKYBITToken.SkybitToken < 1000 || BuyKongS < 0)
        {
            buy2500KongS.SetActive(false);
        }

        if (SKYBITToken.SkybitToken >= 1888 && BuyKongS == 0)
        {
            buy5000KongS.SetActive(true);
        }
        else if (SKYBITToken.SkybitToken < 1888 || BuyKongS < 0)
        {
            buy5000KongS.SetActive(false);
        }
    }
    public void Colleting500KongS()
    {
        if(ShopSystem.Kong500Open == 0)
        {
            KongS1001.SetActive(true);
            KongS1002.SetActive(true);
            KongS1003.SetActive(true);
            KongS1004.SetActive(true);
            KongS1005.SetActive(true);
            
            ShopSystem.Kong500Open -= 1;
            PlayerPrefs.SetInt("kong500Opening", ShopSystem.Kong500Open);
            Invoke("Reset", 86400f);
        }
    }

    public void Buy2500KongS()
    {
        BuyKongS -= 5;
        KongS5001.SetActive(true);
        KongS5002.SetActive(true);
        KongS5003.SetActive(true);
        KongS5004.SetActive(true);
        KongS5005.SetActive(true);
        SKYBITToken.SkybitToken -= 1000;
        PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
    }

    public void Buy5000KongS()
    {
        BuyKongS -= 5;
        KongS10001.SetActive(true);
        KongS10002.SetActive(true);
        KongS10003.SetActive(true);
        KongS10004.SetActive(true);
        KongS10005.SetActive(true);
        SKYBITToken.SkybitToken -= 1888;
        PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
    }

    void Reset()
    {
        ShopSystem.Kong500Open += 1;
        PlayerPrefs.SetInt("kong500Opening", ShopSystem.Kong500Open);
    }
}
