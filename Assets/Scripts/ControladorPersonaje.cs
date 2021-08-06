using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ControladorPersonaje : MonoBehaviour {
    public float fuerzaSalto = 10f;
    public Puntuacion puntuacion;
    public Puntuacion2 puntuacion2;
    private bool corriendo = false;
    public float velocidad = 10f;
    public TextMesh Proton;
    public TextMesh Neutron;
    public TextMesh ProtonTotal;
    public TextMesh NeutronTotal;
    public BarraVida currentHealth;

    private int Total;
    private int TotalElementoQuimicoArmado;

    public TextMesh TotalElemento;

    // Use this for initialization
    void Start () {
	
	}

    void FixedUpdate()
    {
        ProtonTotal.text = puntuacion.puntuacion.ToString();
        NeutronTotal.text = puntuacion2.puntuacion2.ToString();

        if (corriendo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);

            Total = puntuacion.puntuacion + puntuacion2.puntuacion2;


            if (Total == 15)
            {
                TotalElementoQuimicoArmado = Total % 7;
                TotalElemento.text = TotalElementoQuimicoArmado.ToString();
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaGanado");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);

            }
            if (Total == 20)
            {
                TotalElementoQuimicoArmado = Total % 7;
                TotalElemento.text = TotalElementoQuimicoArmado.ToString();
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaGanado");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);

            }
            if (Total == 25)
            {
                TotalElementoQuimicoArmado = Total % 7;
                TotalElemento.text = TotalElementoQuimicoArmado.ToString();
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaGanado");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);

            }
            if (Total == 30)
            {
                TotalElementoQuimicoArmado = Total % 7;
                TotalElemento.text = TotalElementoQuimicoArmado.ToString();
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaGanado");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);

            }
            if (Total == 35)
            {
                TotalElementoQuimicoArmado = Total % 7;
                TotalElemento.text = TotalElementoQuimicoArmado.ToString();
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaGanado");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);

            }


        }



    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (corriendo)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
            }
        }

      else
        {
            corriendo = true;
           
        }


    }








}
