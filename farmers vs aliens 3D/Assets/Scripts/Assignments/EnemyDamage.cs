using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyDamage = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var hit = other.gameObject;
            
            var playerCurrentHealth = hit.GetComponent<PlayerHealth>();
            

            if (playerCurrentHealth != null)
            {
                playerCurrentHealth.TakeDamage(enemyDamage);
                Debug.Log("Ouch, you've been hit!");

            }


        }
    }

   



    // Update is called once per frame
    void Update()
    {
      
        
    }
}
