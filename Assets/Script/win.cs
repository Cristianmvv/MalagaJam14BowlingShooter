using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public float equipoazul, equiporojo;
    public float tiempo;
    public float temporizador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.S))
        {
            equipoazul++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            equiporojo++;
        }


        if(equiporojo>equipoazul)
        {
            Debug.Log("caca");
            //gameObject.SetActive(true);
        }

        if (equipoazul > equiporojo)
        {
            Debug.Log("caca2");
            //gameObject.SetActive(true);
        }

        temporizador+=Time.deltaTime;

        if(temporizador>=tiempo)
        {
            Time.timeScale = 0;
        }
         
    }
}
