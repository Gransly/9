using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float movespeed;
    public Transform camTransform;
    public float jumpforce;
    
    private Transform playerTransform;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    private void Awake()
    {
        
        playerTransform = GetComponent<Transform>();
    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag())
//        {
//            
//        }
//    }


    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.W))
        {
          rb.AddForce(camTransform.forward* movespeed * Time.fixedDeltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-camTransform.forward* movespeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-camTransform.right* movespeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(camTransform.right* movespeed * Time.fixedDeltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up* jumpforce * Time.fixedDeltaTime);
        }
    }
}
