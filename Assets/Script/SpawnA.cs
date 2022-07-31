using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnA   : MonoBehaviour
{
    public GameObject[] Letras;
    private float tiempoEntreflechas;
    public float comienzodetiempo;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(tiempoEntreflechas <= 0)
        {
            int random = Random.Range(0, Letras.Length);    
            Instantiate (Letras[random], transform.position, Quaternion.identity);

            tiempoEntreflechas = comienzodetiempo;

        }
        else
        {
            tiempoEntreflechas-=Time.deltaTime;
        }
    }
}
