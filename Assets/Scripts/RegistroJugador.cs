using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class RegistroJugador : MonoBehaviour {

    //llegan datos
    public InputField txtUsuario;
    public InputField txtNom;
    public InputField txtCorreo;
    public Dropdown dropdownCurso;
    public Dropdown dropdownColegios;
    public InputField valorCurso;
    public InputField valorColegio;
    [SerializeField]
    private Text txtRegistroCompleto = null;

    public string conn;

    List<string> cursos = new List<string>() { "Cursos", "Quinto Basico", "Sexto Basico", "Septimo Basico", "Obtavo Basico", "Primero Medio", "Segundo Medio" };
    
    List<string> colegios = new List<string>() { "Instituto Nacional", "Boston College", "Los Bosquinos", "Polivalente el Llano", "Patricio Mekis" };

    void Start() {
        cursoList();
        colegiosList();
        
    }

    public void IndexCursos(int indexCursos)
    {

        //valorCurso.text = index;
        if (indexCursos == 1)
        {
            valorCurso.text = "Quinto Basico";
        }
        else if (indexCursos == 2)
        {
            valorCurso.text = "SextoBasico";
        }
        else if (indexCursos == 3)
        {
            valorCurso.text = "SeptimoBasico";
        }
        else if (indexCursos == 4)
        {
            valorCurso.text = "ObtavoBasico";
        }
        else if (indexCursos == 5)
        {
            valorCurso.text = "ObtavoBasico";
        }
        else if (indexCursos == 6)
        {
            valorCurso.text = "PrimeroMedio";
        }
        else if (indexCursos == 7)
        {
            valorCurso.text = "SegundoMedio";
        }
        else if (indexCursos == 0) {

            valorCurso.text = "400";
        }


    }

    public void cursoList() {
        dropdownCurso.AddOptions(cursos);
    }


    public void IndexColegios(int indexColegios)
    {

        //valorColegio.text = colegios[indexColegios];

        if (indexColegios == 0)
        {
            valorColegio.text = "Instituto Nacional";
        }
        else if (indexColegios == 1)
        {
            valorColegio.text = "Boston College";
        }
        else if (indexColegios == 2)
        {
            valorColegio.text = "Los Bosquinos";
        }
        else if (indexColegios == 3)
        {
            valorColegio.text = "Polivalente el Llano";
        }
        else if (indexColegios == 4)
        {
            valorColegio.text = "Patricio Mekis";
        }
       


    }

    public void colegiosList() {
        dropdownColegios.AddOptions(colegios);
    }

    public void registroAlumno()
    {
        StartCoroutine(Registro());
    }

    public void jugarDemo() {

        StartCoroutine(DemoScienceManX());
    }

    void Exito(string conn){

        Debug.Log("coneccion.text=" + conn);
        if (conn == "202")
        {
            txtRegistroCompleto.color = Color.green;
            txtRegistroCompleto.text = "Registro Completo\nCargando El Juego";
            StartCoroutine(CargarScienceManX());

        }else{

            txtRegistroCompleto.color = Color.red;
            txtRegistroCompleto.text = "Error";
        }
    }


    IEnumerator Registro()
    {
        Debug.Log(valorCurso.text);
        Debug.Log(valorColegio.text);
        WWW coneccion = new WWW("http://sciencemanx.com/sciencemanx/registroJugador.php?nickName=" + txtUsuario.text+"&nom="+txtNom.text+"&correo="+txtCorreo.text+"&curso="+valorCurso.text+"&colegio="+valorColegio.text+"");
        yield return (coneccion);
        Debug.Log(coneccion.text);
        if (coneccion.text == "202")
        {
            Debug.Log("registrado");
            conn = "202";
            Exito(conn);
        }
        else {
            Debug.Log("NO registrado");
            conn = "400";
            Exito(conn);
        }

    }

    IEnumerator CargarScienceManX() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    
    }

    IEnumerator DemoScienceManX()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);

    }

}
