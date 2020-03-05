using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points = 10;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth -= maxHealth;



    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");
            // add points to your score for killing wolf
            //scoremanager.AddPoints(points);
            //Move wolf to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //reset Wolf Health
            currentHealth = maxHealth;


        }
    }
}

