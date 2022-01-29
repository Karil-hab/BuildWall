using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyContr : MonoBehaviour
{
    float v;
    float h;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }
   

    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");   

        rb.velocity = transform.forward * v * 5f;   
    }

    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
}
