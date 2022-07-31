using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        StartCoroutine(ToTrueMainMenu());
    }

    IEnumerator ToTrueMainMenu()
    {
        yield return null;
        SceneManager.LoadScene("MainMenu");
    }
}
