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

        dialogueOptionsText[0].text = "Sí, todos los días.";
        dialogueOptionsText[1].text = "A veces";
        dialogueOptionsText[2].text = "No es asunto tuyo.";
        dialogueOptionsText[3].text = "No, en realidad soy un flojo.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Qué sueles hacer cuando no estás boxeando?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "Dormir";
        dialogueOptionsText[1].text = "Comer";
        dialogueOptionsText[2].text = "Lo mismo que tú";
        dialogueOptionsText[3].text = "...";


        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Quieres venir a mi casa a tomar unas galletas? Mi hijo hizo algunas ayer.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "¿Son de canela?";
        dialogueOptionsText[1].text = "No gracias, no voy con extraños.";
        dialogueOptionsText[2].text = "Solo si usted toma también.";
        dialogueOptionsText[3].text = "Claro";
       
        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Haces algo de repostería?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "¿Qué es eso?";
        dialogueOptionsText[1].text = "Ni loco";
        dialogueOptionsText[2].text = "Me encanta. Hago cualquier cosa";
        dialogueOptionsText[3].text = "¿Quieres ver mis habilidades?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "¿Por qué no vamos a jugar a los bolos? Hay unas pistas cerca.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "No, no me apetece";
        dialogueOptionsText[1].text = "¿Me estás pidiendo una cita?";
        dialogueOptionsText[2].text = "He oído que tienen algún fallo técnico";
        dialogueOptionsText[3].text = "Venga juguemos juntos";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "Salgamos juntos";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "Adiós";
        dialogueOptionsText[1].text = "Casémonos ya que estamos";
        dialogueOptionsText[2].text = "Vale, ¿a dónde quieres ir?";
        dialogueOptionsText[3].text = "Prefiero conocernos mejor";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "''Dos años después tu y matilda os casáis. Os habéis convertido en grandes luchadores y vivís felizmente en una playa de Miami''";
    }
}
