using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    public BoxCollider colliderToOff;
    public ParticleSystem particl;

    private void Awake()
    {
        particl.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !colliderToOff.enabled)
        {
            particl.Play();
            colliderToOff.enabled = true;
        }
    }
}
