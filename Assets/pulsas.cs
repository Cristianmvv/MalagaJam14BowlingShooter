using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsas : MonoBehaviour
{
    public GameObject lol;
    AudioSource Golpe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Golpe.Play();
            lol.gameObject.SetActive(true); 
        }
    }
}
