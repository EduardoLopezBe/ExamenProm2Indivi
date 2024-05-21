using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    GameObject player;
    public float speed = 5f;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
      
        transform.position += -transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }
}