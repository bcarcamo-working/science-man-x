using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ElementoQuimico : MonoBehaviour {
    [SerializeField]
    private TextMesh txtElementoQuimico = null;
    private string NumNivel;
    // Use this for initialization



    void Start () {

        StartCoroutine(NombreElemento());

    }

    IEnumerator NombreElemento()
    {
        NumNivel = "1";
        WWW coneccion = new WWW("http://sciencemanx.com/sciencemanx/elementoQuimico.php?nivel=" + NumNivel +"");
        yield return (coneccion);
        Debug.Log(coneccion.text);

        txtElementoQuimico.color = Color.green;
        txtElementoQuimico.text = "Debes Armar " + coneccion.text;

    }
    // Update is called once per frame
    void Update () {

    }
}
