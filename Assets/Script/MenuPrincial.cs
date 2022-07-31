using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincial : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ToTrueMainMenu());
    }

    IEnumerator ToTrueMainMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }
}
