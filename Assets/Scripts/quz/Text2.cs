using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Text2 : MonoBehaviour {
    List<string> SecondChoice = new List<string>() { "2 opcion dos", "2 segunda", "2 tercera", "2 cuarta", "2 quinta" };

    // Use this for initialization
    void Start () {
        //GetComponent<TextMesh>().text = SecondChoice[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (Pregunta.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = SecondChoice[Pregunta.randQuestion];
        }
    }
    void OnMouseDown()
    {
         Debug.Log(gameObject.name);

        Pregunta.selectedAnswer = gameObject.name;
        Pregunta.choiceSelected = "y";
    }
}
