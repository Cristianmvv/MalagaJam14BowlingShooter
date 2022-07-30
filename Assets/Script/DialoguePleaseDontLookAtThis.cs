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

        dialogueText.text = "Tienes un buen brazo derecho. ¿Vas al gimnasio?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "1-Sí, todos los días.";
        dialogueOptionsText[1].text = "2-A veces";
        dialogueOptionsText[2].text = "3-No es asunto tuyo.";
        dialogueOptionsText[3].text = "4-No, en realidad soy un flojo.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Qué sueles hacer cuando no estás boxeando?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "1-Dormir";
        dialogueOptionsText[1].text = "2-Comer";
        dialogueOptionsText[2].text = "3-Lo mismo que tú";
        dialogueOptionsText[3].text = "";


        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Quieres venir a mi casa a tomar unas galletas? Mi hijo hizo algunas ayer.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "1-¿Son de canela?";
        dialogueOptionsText[1].text = "2-No gracias, no voy con extraños.";
        dialogueOptionsText[2].text = "3-Solo si usted toma también.";
        dialogueOptionsText[3].text = "4-Claro";



        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));


    }
}
