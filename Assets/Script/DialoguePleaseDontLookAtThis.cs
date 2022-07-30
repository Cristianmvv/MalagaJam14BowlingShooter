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

        dialogueText.text = "Tienes un buen brazo derecho. �Vas al gimnasio?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "S�, todos los d�as.";
        dialogueOptionsText[1].text = "A veces";
        dialogueOptionsText[2].text = "No es asunto tuyo.";
        dialogueOptionsText[3].text = "No, en realidad soy un flojo.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "�Qu� sueles hacer cuando no est�s boxeando?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "Dormir";
        dialogueOptionsText[1].text = "Comer";
        dialogueOptionsText[2].text = "Lo mismo que t�";
        dialogueOptionsText[3].text = "...";


        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "�Quieres venir a mi casa a tomar unas galletas? Mi hijo hizo algunas ayer.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "�Son de canela?";
        dialogueOptionsText[1].text = "No gracias, no voy con extra�os.";
        dialogueOptionsText[2].text = "Solo si usted toma tambi�n.";
        dialogueOptionsText[3].text = "Claro";



        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));


    }
}
