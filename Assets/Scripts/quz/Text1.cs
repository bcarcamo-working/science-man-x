using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Text1 : MonoBehaviour {
    List<string> FirstChoice = new List<string>() { "1 opcion uno" ,"1 segunda","1 tercera","1 cuarta","1 quinta"};
    // Use this for initialization
    void Start () {
       // GetComponent<TextMesh>().text = FirstChoice[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (Pregunta.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = FirstChoice[Pregunta.randQuestion];
        }
    }
    void OnMouseDown()
    {
         Debug.Log(gameObject.name);

        Pregunta.selectedAnswer = gameObject.name;
        Pregunta.choiceSelected = "y";

    }
}
