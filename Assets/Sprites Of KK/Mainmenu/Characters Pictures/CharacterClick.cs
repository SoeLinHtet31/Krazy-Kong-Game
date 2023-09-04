using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterClick : MonoBehaviour
{
    public void StageTran1(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
