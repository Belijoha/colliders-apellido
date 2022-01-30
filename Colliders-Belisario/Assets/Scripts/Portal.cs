using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private bool reducto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "NullPortal")
        {
            Debug.Log("Estoy entrando al portal: " + other.name);
            if (!reducto)
            {
                transform.localScale = transform.localScale / 2;
            }
            else
            {
                transform.localScale = transform.localScale * 2;
                
            }

        }
                
    }
    void OnTriggerStay(Collider other)
    {
        if (other.name == "NullPortal")
        {
            Debug.Log("Estoy en el portal: " + other.name);
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "NullPortal")
        {
            Debug.Log("Salí del portal: " + other.name);
            if (!reducto)
            {
                reducto = true;
            }
            else
                reducto = false;
            }
        }
    }

