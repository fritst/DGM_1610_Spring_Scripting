using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public int playerHealAmount;

    //public int playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        //print("Player health is " + healthAmt);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void OnTriggerEnter(Collider other)
    {

        // Check to see if trigger detected player 
        var playerCurrentHealth = other.gameObject.GetComponent<PlayerHealth>();
        //var AddHealth = other2.gameObject.GetComponent<PlayerHealth>();
        if (other.gameObject.CompareTag("Player"))
        {

            if(playerCurrentHealth != null)
            {
                PlayerHealth.AddHealth(healthToAdd);
            }
            Destroy(gameObject);
        }
    }
    */

    /*void OnCollisionEnter(Collision other2)
    {
        if (other2.gameObject.CompareTag("Player"))
        {
            var heal = other2.gameObject;

            var playerCurrentHealth = heal.GetComponent<PlayerHealth>();


            if (playerCurrentHealth != null)
            {
                playerCurrentHealth.GiveHealth(healthAmt);

                Debug.Log("Mmm, you've been healed!");

            }


        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.GiveHealth(playerHealAmount);
            Debug.Log("Mmm, you've been healed!");
            Destroy(gameObject);

        }
    }

}
