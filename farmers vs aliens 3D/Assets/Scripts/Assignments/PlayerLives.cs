using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int playerMaxLives = 3;
    public int playerCurrentLives;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentLives = playerMaxLives;
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lose(int playerlivesAmount)
    {
        playerCurrentLives -= playerlivesAmount;
        if (playerCurrentLives <= 0)
        {
            playerCurrentLives = 0;
            print("YOU LOSE!");
            //Destroy(gameObject); //hopefully figure out how to actually lose
        }
    }
}
