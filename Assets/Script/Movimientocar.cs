using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientocar : MonoBehaviour
{
    public float speed = 0f;
    public float TurnSpeed = 2f;
    Vector3 velocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * z;

        transform.Rotate(Vector3.up * TurnSpeed * x * Time.deltaTime);


        transform.Translate(Vector3.forward * speed * z * Time.deltaTime);


    }
}
