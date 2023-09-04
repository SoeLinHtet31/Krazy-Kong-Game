using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public GameObject NoviceBOx;
    public GameObject IntermediateBox;
    public GameObject LegendaryBox;

    public GameObject KongS500;
    public GameObject KongS2500;
    public GameObject KongS5000;

    public static int OpeningBox;

    public int ShowOpeningBox;

    public GameObject BG;

    public Animator NovicBoxAnim;
    public Animator InterBoxAnim;
    public Animator LegenBoxAnim;

    public static int NoviceBoxOpen;

    public int NovicBoxTime;

    public static int Kong500Open;

    private void Start()
    {
        OpeningBox = 0;
    }
    private void Awake()
    {
        NoviceBoxOpen = PlayerPrefs.GetInt("noviceBoxOpen", 0);
        Kong500Open = PlayerPrefs.GetInt("kong500Opening", 0);
    }
    private void Update()
    {
        NovicBoxTime = NoviceBoxOpen;
        ShowOpeningBox = OpeningBox;
    }
    public void OpenNoviceBox()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(true);
        IntermediateBox.SetActive(false);
        LegendaryBox.SetActive(false);
        KongS500.SetActive(false);
        KongS2500.SetActive(false);
        KongS5000.SetActive(false);
    }

    public void CloseNoviceBox()
    {
        BG.SetActive(false);
        NoviceBOx.SetActive(false);
    }

    public void OpenInterMediateBox()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(false);
        IntermediateBox.SetActive(true);
        LegendaryBox.SetActive(false);
        KongS500.SetActive(false);
        KongS2500.SetActive(false);
        KongS5000.SetActive(false);
    }

    public void CloseInterMediateBox()
    {
        BG.SetActive(false);
        IntermediateBox.SetActive(false);
    }

    public void OpenLegendaryBox()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(false);
        IntermediateBox.SetActive(false);
        LegendaryBox.SetActive(true);
        KongS500.SetActive(false);
        KongS2500.SetActive(false);
        KongS5000.SetActive(false);
    }

    public void CloseLegendaryBox()
    {
        BG.SetActive(false);
        LegendaryBox.SetActive(false);
    }

    public void Open500KongS()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(false);
        IntermediateBox.SetActive(false);
        LegendaryBox.SetActive(false);
        KongS500.SetActive(true);
        KongS2500.SetActive(false);
        KongS5000.SetActive(false);
    }

    public void Close500KongS()
    {
        BG.SetActive(false);
        KongS500.SetActive(false);
    }

    public void Open2500KongS()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(false);
        IntermediateBox.SetActive(false);
        LegendaryBox.SetActive(false);
        KongS500.SetActive(false);
        KongS2500.SetActive(true);
        KongS5000.SetActive(false);
    }

    public void Close2500KongS()
    {
        BG.SetActive(false);
        KongS2500.SetActive(false);
    }

    public void Open5000KongS()
    {
        BG.SetActive(true);
        NoviceBOx.SetActive(false);
        IntermediateBox.SetActive(false);
        LegendaryBox.SetActive(false);
        KongS500.SetActive(false);
        KongS2500.SetActive(false);
        KongS5000.SetActive(true);
    }

    public void Close5000KongS()
    {
        BG.SetActive(false);
        KongS5000.SetActive(false);
    }


    public void OpeningNoviceBox()
    {
        NovicBoxAnim.SetTrigger("Open");
        NoviceBoxOpen -= 1;
        Invoke("Reset", 86400f);
    }

    public void OpeningIntermediateBox()
    {
        OpeningBox -= 5;
        InterBoxAnim.SetTrigger("Open");
    }

    public void OpeningLengendBox()
    {
        OpeningBox -= 5;
        LegenBoxAnim.SetTrigger("Open");
    }

    void Reset()
    {
        NoviceBoxOpen += 1;
        PlayerPrefs.SetInt("noviceBoxOpen", NoviceBoxOpen);
    }
}
