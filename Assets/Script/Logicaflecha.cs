using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logicaflecha : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;

    public void Update()
    {
        transform.position += transform.up * -velocidad * Time.deltaTime;

        if (contador ==2)
        {
            adentro = true;
        }
        else
        {
            adentro = false;
        }

        if ( Input.GetKeyDown(KeyCode.A))

        {
            if (adentro)
            {
                GameObject.Find("PulsaA").GetComponent<Rithmy>().puntaje++;
                GameObject.Find("PulsaA").GetComponent<Rithmy>().texto.text ="Score : ";
                GameObject.Find("PulsaA").GetComponent<Rithmy>().puntaje.ToString();

                Destroy(gameObject);
            }
        }

    }

      
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            contador++;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Player")
        {
            contador--;
        }
    }
}
