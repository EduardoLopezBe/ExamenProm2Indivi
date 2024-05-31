using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoNgro : VidaEnemy
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletBlack"))
        {
            Life -= Damage;
            if (Life < 0)
            {
                Destroy(gameObject);   // Si el enemigo ngro se choca con la bala negra se destruye 
            }
        }
    }   
}
