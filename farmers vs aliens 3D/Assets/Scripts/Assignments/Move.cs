﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    public float jumpHeight;
    public bool isGrounded;

    private Rigidbody rb;

    public GameObject projectilePrefab;
    public static int currentBulletAmmo;
    public int maxBulletAmmo = 10;
    public Text remainingBulletAmmo;
    public Text fullBulletAmmo;
    public int firedBullet = 1;
    public static bool notOutOfAmmo;
    public int time = 3;


    // Start is called before the first frame update
    void Start()
    {
        currentBulletAmmo = maxBulletAmmo;
        notOutOfAmmo = true;
        StartCoroutine(reload());
        rb = GetComponent<Rigidbody>();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        /*if (currentBulletAmmo >= 0)
        {
            notOutOfAmmo = true;
            
        }*/

        remainingBulletAmmo.text = currentBulletAmmo.ToString();
        fullBulletAmmo.text = maxBulletAmmo.ToString();

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        // x, y, z

        /*if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight * 1000 * Time.deltaTime);
        }*/

        if (Input.GetKeyDown(KeyCode.F) && notOutOfAmmo)
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Move.UseAmmo(firedBullet);
            Debug.Log("You fired the bullet!");
        }

    }

    public static void UseAmmo(int firedBullet)
    {
        
        currentBulletAmmo -= firedBullet;
        if (currentBulletAmmo <= 0)
        {
            
            //keep score at zero
            currentBulletAmmo = 0;
            notOutOfAmmo = false;
            
            print("Out of ammo!");
           




        }
        else if (currentBulletAmmo >= 0)
        {
            notOutOfAmmo = true;
            
        }
    }
    IEnumerator reload()
    {
        if (notOutOfAmmo == false)
        yield return new WaitForSeconds(time);
        //currentBulletAmmo = 10;

    }



    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
            Debug.Log("Colliding with Floor");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = false;
            Debug.Log("Not Colliding with Floor");
        }
    }
    //Detect collision with another object
    /*void OnCollisionEnter(Collision other){
       // Debug.Log("Colliding with an object");

        if (other.gameObject.CompareTag("Floor")) //Primary
        {
            Debug.Log("Colliding with Floor");
        }
        else if(other.gameObject.CompareTag("Obstacle")) //Secondary
        {
            Debug.Log("Colliding with Obstacle");
        }
        else //Default
        {
            Debug.Log("...");
        }



    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Triggered!");
        
    }
    */
}
