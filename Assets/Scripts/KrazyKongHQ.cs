using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KrazyKongHQ : MonoBehaviour
{
    public TextMeshProUGUI BetaSkybitTokenAmount;
    public TextMeshProUGUI OfficialSkybitTokenAmount;

    public GameObject KrazyKongHQPanel;
    public GameObject SwapPanel;

    public int SwapedAmount;

    public GameObject SwapButton;
    public GameObject SwapButton2;

    private void Update()
    {
        SwapedAmount = SKYBITToken.numberOfToken / 2;
        BetaSkybitTokenAmount.text = SKYBITToken.numberOfToken.ToString();
        OfficialSkybitTokenAmount.text = SwapedAmount.ToString();

        if (SKYBITToken.numberOfToken <= 0)
        {
            BetaSkybitTokenAmount.text = "0";
            SwapButton.SetActive(false);
            SwapButton2.SetActive(true);
        }
        else if (SKYBITToken.numberOfToken > 0)
        {
            SwapButton.SetActive(true);
            SwapButton2.SetActive(false);
        }

        if (SwapedAmount <= 0)
        {
            OfficialSkybitTokenAmount.text = "0";
        }
    }

    public void GotoHQPanel()
    {
        KrazyKongHQPanel.SetActive(true);
        SwapPanel.SetActive(false);
    }

    public void GotoSwapPanel()
    {
        KrazyKongHQPanel.SetActive(false);
        SwapPanel.SetActive(true);
    }

    public void ExitHQ()
    {
        KrazyKongHQPanel.SetActive(false);
    }

    public void ExitSwap()
    {
        SwapPanel.SetActive(false);
    }

    public void Swap()
    {
        SKYBITToken.SkybitToken += SwapedAmount;
        PlayerPrefs.SetInt("SkybitToken", SKYBITToken.SkybitToken);
        SwapButton.SetActive(false);
        Invoke("RemoveBetaToken", 0.5f);
        Invoke("SwapButtonActive", 1f);
    }

    void RemoveBetaToken()
    {
        SKYBITToken.numberOfToken -= SKYBITToken.numberOfToken;
        PlayerPrefs.SetInt("NumberOfToken", SKYBITToken.numberOfToken);
    }

    void SwapButtonActive()
    {
        SwapButton.SetActive(true);
    }
}
