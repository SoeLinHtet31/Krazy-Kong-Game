using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMessage : MonoBehaviour
{
    public static int tutorialMessage;
    public int showTotorialMessage;

    private void Awake()
    {
        tutorialMessage = PlayerPrefs.GetInt("tutorialMessage", 0);
    }

    private void Update()
    {
        showTotorialMessage = tutorialMessage;
    }
}
