using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {
    public Slider healthSlider;                               
    public int startingHealth = 100;
    public int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    // Use this for initialization
    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "BajarVida");
        NotificationCenter.DefaultCenter().AddObserver(this, "SubirVida");

    }

    // Update is called once per frame
    void Update () {
        if (currentHealth <= 0)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
            GameObject personaje = GameObject.Find("Personaje");
            personaje.SetActive(false);
        }

    }


    void BajarVida(Notification notificacion)
    {
        int vidaABajar = (int)notificacion.data;
        currentHealth -= vidaABajar;
        ActualizarVida();
    }
    void SubirVida(Notification notificacion)
    {
        int vidaASubir = (int)notificacion.data;
        currentHealth += vidaASubir;
        ActualizarVida();
    }
    void ActualizarVida()
    {
        healthSlider.value = currentHealth;
    }


}
