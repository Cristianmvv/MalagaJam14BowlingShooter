using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
    using UnityEngine.SceneManagement;

public class Rithmy : MonoBehaviour
{
    public int puntaje = 0;
    public TextMeshProUGUI texto;
    public int contador = 0;
    public bool adentro = false;

    private void Start()
    {
        texto= GameObject.Find("ScoreUi").GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if(contador==2)
        {
           adentro=true;
        }
        else
        {
            adentro =false;
        }
    }
}
