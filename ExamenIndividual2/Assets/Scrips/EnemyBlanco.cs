using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlanco : VidaEnemy
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletWhite")) 
        {
            Life -= Damage;
            if (Life < 0) 
            {
                Destroy(gameObject);
            }
        }
    }
}
