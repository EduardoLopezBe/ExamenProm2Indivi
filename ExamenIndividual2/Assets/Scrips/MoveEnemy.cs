using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
      
        transform.position += -transform.up * speed * Time.deltaTime; // que se mueve hacia abajo en cierta velocidad 
    }
                                                                      //TECNICO la posicion actual se iguala a una posicion nueva y hace que se mueva 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }
}