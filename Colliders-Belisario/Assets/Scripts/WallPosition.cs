using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPosition : MonoBehaviour
{
    private Vector3 Este;
    private Vector3 Oeste;
    private Vector3 Norte;
    private Vector3 Sur;
    private const float TimeOrigin = 2f;
    private float TimeToMove;
    // Start is called before the first frame update
    void Start()
    {
        TimeToMove = TimeOrigin;
        Este = transform.position;
        Oeste = new Vector3 (2.7f, 2, -7.45f);
        Norte = new Vector3 (-8.3f, 2, -0.87f);
        Sur = new Vector3 (7.69f, 2, -0.87f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Estoy entrando en colision con el objeto: " + collision.gameObject.name);
            
        }

        
        
    }
    private void ResetTimer()
    {
        TimeToMove = TimeOrigin;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Estoy en colision con el objeto: " + collision.gameObject.name);
        }
        
        TimeToMove -= Time.deltaTime;

        if (TimeToMove <= 0)

        {
            MoveWall();
            RotateWall();
            ResetTimer();
        }

    }

    private void MoveWall()
    {
        int valor = Random.Range(0, 4);
        switch (valor)
        {
            case 1:
                MoveOeste();
                break;
            case 2:
                MoveNorte();
                break;
            case 3:
                MoveSur();
                break;
            default:
                MoveEste();
                break;
        }
        
    }
    private void MoveEste()
    {

        transform.position = Este;
    }
    private void MoveOeste()
    {
        
        transform.position = Oeste;
        
    }
    private void MoveNorte()
    {
        
        transform.position = Norte;
        
    }
    private void MoveSur()
    {
        
        transform.position = Sur;
        
    }
    private void RotateWall()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 361), 0));
    }
}

