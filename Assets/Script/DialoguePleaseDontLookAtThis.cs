using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguePleaseDontLookAtThis : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] GameObject optionsBox;
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI[] dialogueOptionsText;
    //TextMeshProUGUI[] dialogueOptionsText;

    void Start()
    {
        StartCoroutine(Dialogue());
    }

    IEnumerator Dialogue()
    {
        optionsBox.SetActive(false);

        dialogueText.text = "cosas";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "ssdfsdf";
        dialogueOptionsText[1].text = "ssdfsdf";
        dialogueOptionsText[2].text = "ssdfsdf";
        dialogueOptionsText[3].text = "ssdfsdf";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "cosas";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "ssdfsdf";
        dialogueOptionsText[1].text = "ssdfsdf";
        dialogueOptionsText[2].text = "ssdfsdf";
        dialogueOptionsText[3].text = "ssdfsdf";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "cosas";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));


    }
}
