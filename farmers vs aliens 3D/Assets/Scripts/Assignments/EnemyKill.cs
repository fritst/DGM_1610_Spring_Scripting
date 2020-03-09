using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public int playerLoseLife = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            var hit = other.gameObject;
            var health = hit.GetComponent<PlayerHealth>();


            var life = other.gameObject;
            var lives = life.GetComponent<PlayerLives>();

            if (lives != null)
            {
                lives.Lose(playerLoseLife);
                Debug.Log("You died!");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
