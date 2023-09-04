using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed;

    public static int StartingDialogue;
    public int showDialogueAmount;
    public TextMeshProUGUI StartingDialogueTimeText;

    private int index;

    public GameObject Blocker;
    public GameObject Blocker2;
    public GameObject Blocker3;

    public GameObject NextText;

    public Transform gameCityName;

    public GameObject Shop;

    private void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    private void Awake()
    {
        StartingDialogue = PlayerPrefs.GetInt("StartingDialogue", 0);
    }

    private void Update()
    {
        showDialogueAmount = StartingDialogue;
        if (StartingDialogue == 0)
        {
            gameObject.SetActive(true);
            Blocker.SetActive(true);
        }

        else if (StartingDialogue < 0)
        {
            gameObject.SetActive(false);
            Blocker.SetActive(false);
        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

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

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }



    
    public void OnDisable()
    {
        gameCityName.transform.SetParent(Shop.transform);
        Blocker.SetActive(false);
        NextText.SetActive(true);
        Blocker2.SetActive(true);
        gameObject.SetActive(false);
        StartingDialogue -= 1;
        PlayerPrefs.SetInt("StartingDialogue", StartingDialogue);
    }

}
