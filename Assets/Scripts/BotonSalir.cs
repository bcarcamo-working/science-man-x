using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BotonSalir : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Application.Quit();
    }
}
