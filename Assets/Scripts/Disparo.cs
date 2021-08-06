using UnityEngine;
using System.Collections;
using System;

public class Disparo : MonoBehaviour
{
    public Rigidbody2D rocket;              // Prefab of the rocket.
    public float speed = 20f;               // The speed the rocket will fire at.


    void Awake()
    {
        // Setting up the references.
      
    }


    void Update()
    {
        // If the fire button is pressed...
        if (Input.GetMouseButtonDown(0))
        {
            // ... set the animator Shoot trigger parameter and play the audioclip.
           // anim.SetTrigger("Shoot");
           // GetComponent<AudioSource>().Play();

            // If the player is facing right...
           
                // ... instantiate the rocket facing right and set it's velocity to the right. 
                Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(speed, 0);
            
        }
    }
}
