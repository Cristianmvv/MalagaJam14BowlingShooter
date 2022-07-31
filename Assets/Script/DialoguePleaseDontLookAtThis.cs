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

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "�Haces algo de reposter�a?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "�Qu� es eso?";
        dialogueOptionsText[1].text = "Ni loco";
        dialogueOptionsText[2].text = "Me encanta. Hago cualquier cosa";
        dialogueOptionsText[3].text = "�Quieres ver mis habilidades?";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "�Por qu� no vamos a jugar a los bolos? Hay unas pistas cerca.";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(true);
        dialogueBox.SetActive(false);

        dialogueOptionsText[0].text = "No, no me apetece";
        dialogueOptionsText[1].text = "�Me est�s pidiendo una cita?";
        dialogueOptionsText[2].text = "He o�do que tienen alg�n fallo t�cnico";
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

        dialogueOptionsText[0].text = "Adi�s";
        dialogueOptionsText[1].text = "Cas�monos ya que estamos";
        dialogueOptionsText[2].text = "Vale, �a d�nde quieres ir?";
        dialogueOptionsText[3].text = "Prefiero conocernos mejor";

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

        optionsBox.SetActive(false);
        dialogueBox.SetActive(true);

        dialogueText.text = "''Dos a�os despu�s tu y matilda os cas�is. Os hab�is convertido en grandes luchadores y viv�s felizmente en una playa de Miami''";
    }
}
