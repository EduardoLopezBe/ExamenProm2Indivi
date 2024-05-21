using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private int Municion;
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Municion > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject obj = Instantiate(prefab[0]);
                obj.transform.position = shootPoint.position;
                obj.GetComponent<Bullet>().SetDirection(shootPoint.up);
                Destroy(obj, 2);
                Municion--;
            }
            if (Input.GetMouseButtonDown(1))
            {
                GameObject obj = Instantiate(prefab[1]);
                obj.transform.position = shootPoint.position;
                obj.GetComponent<Bullet>().SetDirection(shootPoint.up);
                Municion--;
                Destroy(obj, 2);
            }
        }
    }
}
