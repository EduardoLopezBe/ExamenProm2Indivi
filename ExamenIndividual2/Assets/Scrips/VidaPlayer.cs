using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    [SerializeField] protected int LifePlyer;
    public int Damage = 10;
    private void Update()
    {
        if (LifePlyer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LifePlyer -= Damage;
        }
    }
}