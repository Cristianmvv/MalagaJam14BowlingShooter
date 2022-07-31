using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   //public AudioMixer;


    public void Tenis()
    {
        SceneManager.LoadScene("Tenis");
    }
    public void Beisbol()
    {
        SceneManager.LoadScene("Besibol");
    }
    public void Bolos()
    {
        SceneManager.LoadScene(5);
    }
    public void Golf()
    {
        SceneManager.LoadScene("Golf");
    }
    public void Boxeo()
    {
        SceneManager.LoadScene("Boxeo");
    }
    public void Quite()
    {
        Application.Quit();
    }
}
