using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public float equipoazul, equiporojo;
    public float tiempo;
    public float temporizador;
    public bool parar;

    public float preparados;
        public float uno;
        public float dos;
    public float tres;
    public float Go;
    public float valortotal;
    public Slider sliderPrefab;
    public AudioSource golpe;


    

   public GameObject Rojo, azul2,Uno,Dos,Tres;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        valortotal = equipoazul + equiporojo + 1f;
        preparados += Time.deltaTime;
        sliderPrefab.value = equipoazul + 0.5f;
        sliderPrefab.maxValue = valortotal;
        if(preparados >= tres)
        {
            Tres.gameObject.SetActive(false);
            Dos.gameObject.SetActive(true);

        }
        if (preparados >= dos)
        {
            Dos.gameObject.SetActive(false);
            Uno.gameObject.SetActive(true);

        }

        if (preparados >= Go)

        {
            Uno.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.S) && parar == false)
            {
                golpe.Play();
                equipoazul++;
            }
            if (Input.GetKeyDown(KeyCode.K) && parar == false)
            {
                golpe.Play();
                equiporojo++;
            }
            temporizador += Time.deltaTime;

            if (temporizador >= tiempo)
            {
                parar = true;
                if (equiporojo > equipoazul)
                {
                    Debug.Log("caca");
                    Rojo.gameObject.SetActive(true);
                }

                if (equipoazul > equiporojo)
                {

                    azul2.gameObject.SetActive(true);
                }
                Time.timeScale = 0;
            }

        }

    }

         


      
       
}
