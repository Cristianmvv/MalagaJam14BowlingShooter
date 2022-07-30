using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public AudioMixer;
                public static GameMenu gm;



    private void start()

if (gm == null)
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
}
        else
    Destroy(gameObject);

    }
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
        SceneManager.LoadScene("Bolos");
    }
    public void Golf()
    {
        SceneManager.LoadScene("Golf");
    }
    public void Boxeo()
    {
        SceneManager.LoadScene("Boxeo");
    }
}
