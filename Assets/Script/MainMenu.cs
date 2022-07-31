using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public AudioMixer;



    public void Tenis()
    {
        SceneManager.LoadScene(7);
    }
    public void Beisbol()
    {
        SceneManager.LoadScene(4);
    }
    public void Bolos()
    {
        SceneManager.LoadScene(5);
    }
    public void Golf()
    {
        SceneManager.LoadScene(3);
    }
    public void Boxeo()
    {
        SceneManager.LoadScene(1);
    }
    public void Quite()
    {
        SceneManager.LoadScene(6);
    }
}
