using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    public int attackDamage = 10;               // The amount of health taken away per attack.
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    void Awake()
    {
        // Setting up the references.
      
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        // If the entering collider is the player...

        if (collider.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "BajarVida", attackDamage);
            Destroy(gameObject);
        }
        
    }
 

}