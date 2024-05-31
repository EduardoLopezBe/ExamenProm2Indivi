using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyCollection
{
    [SerializeField] private List<GameObject> enemies;     //scrip donde se crea una lista de objetos 

    public List<GameObject> Enemies { get { return enemies; } }
}