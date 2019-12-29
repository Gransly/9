using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{

        private bool isInvincible =  true;
        private CheckPointMaster check;
        
        private Rigidbody playerRb;
        private Transform playerTrans;
        
        private void Awake()
        { 
                playerTrans = GetComponent<Transform>();
                playerRb = GetComponent<Rigidbody>();
        }

        private void OnTriggerStay(Collider other)
        {
                if (other.CompareTag("Enemy") && HealthControl.health > 0 &&  isInvincible)
                { 
                        Debug.Log("EnemyHit");
                        isInvincible = false;
                        HealthControl.health--;
                        StartCoroutine(GetInvulnerable());
                }
                
                if (other.CompareTag("Enemy") && HealthControl.health == 0 )
                { 
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                
        }

        private void OnTriggerEnter(Collider other)
        {
                if (other.CompareTag("End")) 
                { 
                        check = GameObject.FindGameObjectWithTag("CPM").GetComponent<CheckPointMaster>(); 
                        HealthControl.health--;
                        Debug.Log("EndHit");
                        playerRb.velocity = Vector3.zero;
                        playerTrans.position = check.lastCheckpointPose;
                }
                
        }

        IEnumerator GetInvulnerable()
        { 
                yield return    new WaitForSeconds(3f);
                isInvincible = true;
        }

        
}
