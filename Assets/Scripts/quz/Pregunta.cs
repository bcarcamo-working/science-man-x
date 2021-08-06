using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pregunta : MonoBehaviour {
    List<string> questions = new List<string>() { "Esta es una presgunta", "Segunda pregunta ", "Tercera pregunta", "cuarta pregunta", "quinta pregunta" };

    List<string> correct = new List<string>() {"1","2","3","4","3" };

    public Transform resultObj;

    public static string selectedAnswer;

    public static string choiceSelected = "n";

    public static int randQuestion=-1;
    // Use this for initialization
    void Start () {
       // GetComponent<TextMesh>().text = questions[0];
	}
	
	// Update is called once per frame
	void Update () {
        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0, 5);
        }
        if (randQuestion > -1)
        {
            GetComponent<TextMesh>().text = questions[randQuestion];
        }
        // Debug.Log(questions[randQuestion]);

        if (choiceSelected == "y")
        {
            choiceSelected = "n";

            if (correct[randQuestion] == selectedAnswer)
            {
                Debug.Log("Correct "+ " "+randQuestion);

                resultObj.GetComponent<TextMesh>().text = "Correct";
            }
        }
    }
}
