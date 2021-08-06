using UnityEngine;
using System.Collections;

public class Puntuacion2 : MonoBehaviour {

    // Use this for initialization
    public int puntuacion2 = 0;
    public TextMesh marcador2;
    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos2");
    }
    void IncrementarPuntos2(Notification notificacion)
    {
        int puntosAIncrementar2 = (int)notificacion.data;
        puntuacion2 += puntosAIncrementar2;
        ActualizarMarcador2();
    }
    void ActualizarMarcador2()
    {
        marcador2.text = puntuacion2.ToString();
    }
    // Update is called once per frame
    void Update () {
	
	}
}
