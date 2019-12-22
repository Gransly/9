using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingPlatform : MonoBehaviour
{
    public float disapearingTime;
    public float showTime;
    
    private Collider platformCollider;
    private MeshRenderer platformMesh;
    private void Awake()
    {
        platformCollider =GetComponent<Collider>();
        platformMesh =GetComponent<MeshRenderer>();
    }
    
    void OnCollisionEnter(Collision coll)
        {
            if (coll.collider.CompareTag("Player"))
            {
                StartCoroutine(Hide());
                StartCoroutine(Show());
            }
        }

        IEnumerator Hide()
        {
            yield return new WaitForSeconds(disapearingTime);
            platformCollider.enabled = false;
            platformMesh.enabled = false;
        }
        
        IEnumerator Show()
        {
            yield return new WaitForSeconds(showTime);
            platformCollider.enabled = true;
            platformMesh.enabled = true;
        }
}
