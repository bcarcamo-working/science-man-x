using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Text4 : MonoBehaviour {

    List<string> FourthChoice = new List<string>() { "4 opcion cuatro" ,"4  segunda", "4  tercera", "4 cuarta", "4 quinta" };
    // Use this for initialization
    void Start()
    {
       // GetComponent<TextMesh>().text = FourthChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Pregunta.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = FourthChoice[Pregunta.randQuestion];
        }
    }
    void OnMouseDown()
    {
         Debug.Log(gameObject.name);

        Pregunta.selectedAnswer = gameObject.name;
        Pregunta.choiceSelected = "y";
    }
}
