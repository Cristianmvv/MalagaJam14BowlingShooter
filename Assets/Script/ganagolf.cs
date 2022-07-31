using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganagolf : MonoBehaviour
{

    public GameObject lol;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bola") )
        {
            lol.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
            }
}
