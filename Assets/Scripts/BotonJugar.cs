﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BotonJugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        SceneManager.LoadScene("Login");
    }
}
