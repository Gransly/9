using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
//    private void Update()
//    {
//        if (HealthControl.health == 0)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//        }
//    }
//
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Enemy"))
//        {
//            StartCoroutine(Damage());
//        }
//
//        if (other.gameObject == null)
//        {
//            StopAllCoroutines();
//        }
//    }
//
//    private void OnTriggerExit(Collider other)
//    {
//        if (other.CompareTag("Enemy"))
//        {
//            StopAllCoroutines();
//        }
//    }
//    
//
//    IEnumerator Damage()
//    {
//        while (HealthControl.health > 0)
//        {
//            HealthControl.health--;
//            yield return new WaitForSeconds(2.0f);
//        }
//    }

        private Renderer rend;
        private Color c;
        private bool isInvincible =  true;

        private void Start()
        {
                rend = GetComponent<Renderer>();
                c = rend.material.color;
        }

        private void OnTriggerStay(Collider other)
        {
                if (other.CompareTag("Enemy")&& HealthControl.health > 0 &&  isInvincible)
                {
                        isInvincible = false;
                        HealthControl.health--;
                        StartCoroutine(GetInvulnerable());
                }      
        }
//        private void OnCollisionEnter(Collision other)
//        {
//                if (other.collider.CompareTag("Enemy")&& HealthControl.health > 0)
//                {
//                        HealthControl.health--;
//                        StartCoroutine(GetInvulnerable());
//                }
//        }

        IEnumerator GetInvulnerable()
        {
            yield return    new WaitForSeconds(3f);
            isInvincible = true;
        }

        
}
