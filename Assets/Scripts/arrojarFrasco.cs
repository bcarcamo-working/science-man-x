using UnityEngine;
using System.Collections;

public class arrojarFrasco : MonoBehaviour {

    public enum Direccion { Horizontal, Vertical }
    // Use this for initialization
    //Variables públicas
    public Direccion DireccionArma = Direccion.Horizontal;
    public float Velocidad = 5F;
    public int attackDamage = 10;
    //Variables privadas
    private Rigidbody2D thisRigidbody;

    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody2D>();
      
    }

    void Update()
    {
        //Establecemos su velocidad y su dirección
        if (DireccionArma == Direccion.Horizontal)
        {
            //Movemos el arma en horizontal
            thisRigidbody.transform.Translate(new Vector3(Velocidad, 0, 0) * Time.deltaTime);
        }
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "SubirVida", attackDamage);
            Destroy(gameObject);
        }
    }
}
