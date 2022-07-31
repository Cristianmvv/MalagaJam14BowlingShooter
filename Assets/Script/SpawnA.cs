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
        InvokeRepeating("SpawnFlechas", tiempoEntreflechas, tiempoEntreflechas);
    }

    /*private void Update()
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
    }*/

    public void SpawnFlechas()
    {
        int random = Random.Range(0, Letras.Length);
        Instantiate(Letras[0], transform.position, Quaternion.identity);
    }
}
