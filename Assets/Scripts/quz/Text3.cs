using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Text3 : MonoBehaviour {
    List<string> ThirdChoice = new List<string>() { "3 opcion tres", "3  segunda", "3  tercera", "3 cuarta", "3 quinta" };
    // Use this for initialization
    void Start () {
       // GetComponent<TextMesh>().text = ThirdChoice[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (Pregunta.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = ThirdChoice[Pregunta.randQuestion];
        }
    }
    void OnMouseDown()
    {
        Debug.Log(gameObject.name);

        Pregunta.selectedAnswer = gameObject.name;
        Pregunta.choiceSelected = "y";
    }
}
