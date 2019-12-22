using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Rigidbody pleyrRb;
    public float elevForce;
    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            pleyrRb.AddForce(Vector3.up * elevForce * Time.fixedDeltaTime);
        }
    }
}
