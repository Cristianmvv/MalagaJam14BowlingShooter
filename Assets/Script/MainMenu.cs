using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioSource boton;



    public void Tenis()
    {
        boton.Play();
        SceneManager.LoadScene(4);
    }
    public void Beisbol()
    {
        boton.Play();
        SceneManager.LoadScene(2);
    }
    public void Bolos()
    {
        boton.Play();
        SceneManager.LoadScene(6);
    }
    public void Golf()
    {
        boton.Play();
        SceneManager.LoadScene(5);
    }
    public void Boxeo()
    {
        boton.Play();
        SceneManager.LoadScene(1);
    }
    public void Quite()
    {
        boton.Play();
        SceneManager.LoadScene(0);
    }
}
