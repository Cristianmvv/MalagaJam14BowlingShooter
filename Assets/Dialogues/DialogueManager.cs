using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
public class DialogueManager : MonoBehaviour
{
/*
    [Header("Dialogue UI")]
     public GameObject dialoguePanel;
     public TextMeshProUGUI dialogueText;

    [HEADER("choise ui")]
    public Gameobject[] choices;
    public TextMeshProUGUI choisesText;
    //controles de diálogo

    //otros
    private Story currentStory;

    private bool dialogueIsPlaying;
    
    private static DialogueManager instance;

   

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        choisesText = TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choices.GetComponentInchildren<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();

  
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
        }
        else
        {
            ExitDialogueMode();
        }
    }
    private void DisplayChoices()
    {
        List<Choices> currentChoices = currentStory.currentChoices;
    }*/
}
