using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

    // Use this for initialization
    public InputField txtNickName;
    public InputField txtCorreo;
    [SerializeField]
    private Text txtRegistro = null;

    void Start () {
	
	}

    public void registroLogin()
    {
        StartCoroutine(RegistroLogin());
    }

    void Exito(string resultado)
    {

        if (resultado == "202")
        {
            txtRegistro.color = Color.green;
            txtRegistro.text = "Login Completo\nCargando el juego";
            StartCoroutine(CargarScienceManX());

        }
        else
        {

            txtRegistro.color = Color.red;
            txtRegistro.text = "Login incorrecto\nDebe verificar su nickName o correo";
        }
    }

    IEnumerator RegistroLogin()
    {
      
        WWW coneccion = new WWW("http://sciencemanx.com/sciencemanx/login.php?nickName=" + txtNickName.text + "&correo=" + txtCorreo.text + "");
        yield return (coneccion);

        string input = coneccion.text;
        string resultado = input.Substring(0, 3);
        string nickName = input.Substring(3);

        if (resultado == "202")
        {
            Debug.Log("Login Correcto");
            Exito(resultado);
        }
        else {
            Debug.Log("Login Incorrecto");
            Exito(resultado);
        }
    
    }

    IEnumerator CargarScienceManX()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);

    }
    // Update is called once per frame
    void Update () {
	
	}
}
