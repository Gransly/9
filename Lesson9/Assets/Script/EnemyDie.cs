using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class EnemyDie : MonoBehaviour
{
    public Object Enemy;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Console.WriteLine("EnemyDie");
            Destroy(Enemy);
        }
    }
    
}
