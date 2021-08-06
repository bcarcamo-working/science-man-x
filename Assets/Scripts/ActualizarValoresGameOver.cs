using UnityEngine;
using System.Collections;

public class ActualizarValoresGameOver : MonoBehaviour {


    public TextMesh Record;
    public Puntuacion puntuacion;
    public Puntuacion2 puntuacion2;
    public TextMesh ProtonTotal;
    public TextMesh NeutronTotal;

    private int Total;
    private int TotalElementoQuimicoArmado;

    public TextMesh TotalElemento;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        ProtonTotal.text = puntuacion.puntuacion.ToString();
        NeutronTotal.text = puntuacion2.puntuacion2.ToString();
        Total = puntuacion.puntuacion + puntuacion2.puntuacion2;
        Record.text =  EstadoJuego.estadoJuego.puntuacionMaxima.ToString();

        if (Total == 7)
        {
            
            TotalElemento.text = "1";

        }
    }
}
