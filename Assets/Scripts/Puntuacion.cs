using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    public int puntuacion = 0;
   
    public TextMesh marcador;
   

    // Use this for initialization
    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

       
    }
    void PersonajeHaMuerto(Notification notification)
    {
        if(puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima)
        {
            Debug.Log("Puntuacion maxima superada Maxima: " + EstadoJuego.estadoJuego.puntuacionMaxima+" Actual: "+puntuacion);
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;

            EstadoJuego.estadoJuego.Guardar();
        }
        else
        {
            Debug.Log("Record no superado... Maxima: " + EstadoJuego.estadoJuego.puntuacionMaxima + " Actual: " + puntuacion);

        }
    }
    void IncrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcador();
    }
   



    void ActualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }
   
    // Update is called once per frame
    void Update () {
	
	}
}
