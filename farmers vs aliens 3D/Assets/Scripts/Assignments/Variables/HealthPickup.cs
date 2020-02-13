using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public int healthAmt = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("Player health is " + healthAmt);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("You Gained " + healthAmt + " Health!");
        Destroy(gameObject);
    }

}
