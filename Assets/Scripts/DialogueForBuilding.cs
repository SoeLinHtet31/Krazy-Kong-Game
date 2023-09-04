using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueForBuilding : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed;


    private int index;



    private void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    private void Update()
    {
        
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }

    public void GoToAdventure(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    IEnumerator TypeLine()
    {
        //Type each character 1 by 1
        foreach (char C in lines[index].ToCharArray())
        {
            dialogueText.text += C;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    

}
