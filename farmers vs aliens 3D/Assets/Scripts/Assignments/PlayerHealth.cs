using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Transform player;

    public int playerCurrentHealth;
    public int playerMaxHealth = 10;

    public Transform playerSpawnPoint;

    public Text HP;
    public Text MaxHP;
    

    
        

    //public int playerCurrentLives;


    // Start is called before the first frame update
    void Start()
    {
        
        //PlayerLives playerCurrentLives = playerCurrentLives.GetComponent<PlayerLives>();
        playerCurrentHealth = playerMaxHealth;
        playerSpawnPoint = GameObject.Find("PlayerSpawnPoint").transform;
        player = GameObject.Find("Player").transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = playerCurrentHealth.ToString();
        MaxHP.text = playerMaxHealth.ToString();
    }

    

    public void TakeDamage(int playerHealthAmount)
    {
        playerCurrentHealth -= playerHealthAmount;
        if (playerCurrentHealth <= 0)
        {
            //keep score at zero
            playerCurrentHealth = 0;
            print("You died!");
            //print("Lives Remaining: " + PlayerLives.playerCurrentLives);
            // lose points for dying
            //ScoreManager.AddPoints(diePoints);
            //Move Player to spawn point for restart
            transform.position = playerSpawnPoint.position;
            transform.rotation = playerSpawnPoint.rotation;
            //reset Player Health
            playerCurrentHealth = playerMaxHealth;



        }
    }

    

    
}
