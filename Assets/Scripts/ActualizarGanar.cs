using UnityEngine;
using System.Collections;

public class ActualizarGanar : MonoBehaviour {

    public Puntuacion puntuacion;
    public Puntuacion2 puntuacion2;
    public TextMesh ProtonTotal;
    public TextMesh NeutronTotal;

    private int Total;
    private int TotalElementoQuimicoArmado;

    public TextMesh TotalElemento;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        ProtonTotal.text = puntuacion.puntuacion.ToString();
        NeutronTotal.text = puntuacion2.puntuacion2.ToString();
        Total = puntuacion.puntuacion + puntuacion2.puntuacion2;


        if (Total == 15)
        {
            TotalElementoQuimicoArmado = Total % 7;
            TotalElemento.text = TotalElementoQuimicoArmado.ToString();
            

        }
        if (Total == 20)
        {
            TotalElementoQuimicoArmado = Total % 7;
            TotalElemento.text = TotalElementoQuimicoArmado.ToString();
           
        }
        if (Total == 25)
        {
            TotalElementoQuimicoArmado = Total % 7;
            TotalElemento.text = TotalElementoQuimicoArmado.ToString();
          

        }
        if (Total == 30)
        {
            TotalElementoQuimicoArmado = Total % 7;
            TotalElemento.text = TotalElementoQuimicoArmado.ToString();
           

        }
        if (Total == 35)
        {
            TotalElementoQuimicoArmado = Total % 7;
            TotalElemento.text = TotalElementoQuimicoArmado.ToString();
          

        }
    }
}
