using UnityEngine;
using System.Collections;

public class ActivarGanar : MonoBehaviour {
    public GameObject camaraGanar;

    // Use this for initialization
    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaGanado");
    }
    void PersonajeHaGanado(Notification notificacion)
    {

        camaraGanar.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
        
	}
}
