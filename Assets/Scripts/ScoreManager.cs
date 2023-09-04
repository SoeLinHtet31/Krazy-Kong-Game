using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text KongScore;
    public TMP_Text HighScoreKongS;

 


    int Score = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        KongScore.text = Score.ToString() + "$";
    }
    public void AddPoint()
    {
        Score += Random.Range(5, 10);
        KongScore.text = Score.ToString() + "$";
    }
}
