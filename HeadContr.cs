using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadContr : MonoBehaviour
{
    Transform head_tr;

    float MouseX;
    float MouseY;

    public GameObject FirstrCamera;
    public GameObject ThirdCamera;
    public float sens = 3f;

    bool setActive = true; 
    
    void Start()
    {
        head_tr = GetComponent<Transform>();
    }


    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -30, 30);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);

        FindObjectOfType<BodyContr>().Poluchatel(MouseX);

        if(Input.GetKeyDown("c"))
        {
            setActive = !setActive;

            ThirdCamera.SetActive(setActive);
            FirstrCamera.SetActive(!setActive);  

            /*if(setActive==true)
            {
                ThirdCamera.SetActive(true);
                FirstrCamera.SetActive(false);  
                setActive = false;
            }
            else
            {
                ThirdCamera.SetActive(false);
                FirstrCamera.SetActive(true);  
                setActive = true;
            }*/
        }
    }
}
