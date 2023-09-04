using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public AudioSource FirstStageMusic;
    public AudioSource SecondStageMusic;
    public AudioSource Stage1BossMusic;
    public AudioSource Stage2BossMusic;

    public GameObject Stage1MusicTrigger;
    public GameObject Stage2MusicTrigger;

    public int ShowStageAmount;
    public static int StageAmount;

    private void Start()
    {
        Stage1MusicTrigger.SetActive(true);
        Stage2MusicTrigger.SetActive(true);
    }

    private void Update()
    {
        ShowStageAmount = StageAmount;
        if(StageAmount == 1)
        {
            Stage2MusicTrigger.SetActive(true);
        }
        else if (StageAmount == 2)
        {
            Stage1MusicTrigger.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "FirstStage")
        {
            StageAmount = 1;
            FirstStageMusic.Play();
            SecondStageMusic.Stop();
            Stage1BossMusic.Stop();
            Stage2BossMusic.Stop();
        }

        if (collision.name == "SecondStage")
        {
            StageAmount = 2;
            FirstStageMusic.Stop();
            SecondStageMusic.Play();
            Stage1BossMusic.Stop();
            Stage2BossMusic.Stop();
        }

        if (collision.name == "FirstStageBoss")
        {
            FirstStageMusic.Stop();
            SecondStageMusic.Stop();
            Stage1BossMusic.Play();
            Stage2BossMusic.Stop();
        }

        if (collision.name == "SecondStageBoss")
        {
            FirstStageMusic.Stop();
            SecondStageMusic.Stop();
            Stage1BossMusic.Stop();
            Stage2BossMusic.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "FirstStage")
        {
            Stage1MusicTrigger.SetActive(false);
        }

        if (collision.name == "SecondStage")
        {
            Stage2MusicTrigger.SetActive(false);
        }

        if (collision.name == "FirstStageBoss")
        {
            if (StageAmount == 1)
            {
                FirstStageMusic.Play();
                SecondStageMusic.Stop();
                Stage1BossMusic.Stop();
                Stage2BossMusic.Stop();
            }
        }

        if (collision.name == "SecondStageBoss")
        {
            if (StageAmount == 2)
            {
                FirstStageMusic.Stop();
                SecondStageMusic.Play();
                Stage1BossMusic.Stop();
                Stage2BossMusic.Stop();
            }
        }
    }
}
