using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    /* Declaration
    public int number = 20;

    public float waterBottle;

    private string firstName;

    public double rbi;

    public GameObject player;
    */

    public float amount = 5;
    public float money = 21;
    public float cost = 4;


    // Declaration and initialization
    //int number = 20;



    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount, money, cost);

        //Function Call
        //CheckScore();



        //Debug.Log("How many cookies are in the jar " + number);
    }   


    // Update is called once per frame
    void Update()
    {
        
    }


    //int calculator()
    
    void Cookies(float amount, float money, float cost)
    {
        float total = money - amount * cost;

        //Debug.Log(total);
        print(total);
        
        print("Hello World!");

    }

}
