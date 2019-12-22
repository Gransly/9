using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOffOn : MonoBehaviour
{
    public BoxCollider colliderToOff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !colliderToOff.enabled)  //TODO одновременно включается и отключается
        {
            Debug.Log("on");
            colliderToOff.enabled = true;
        }
        
        if (other.CompareTag("Player") && colliderToOff.enabled)
        {
            Debug.Log("off");
            colliderToOff.enabled = false;
        }
        
        
    }
}
