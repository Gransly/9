using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleport2;
    public GameObject something;
    private void OnTriggerEnter(Collider other)
    {
        something.transform.position = teleport2.transform.position;
    }
}
