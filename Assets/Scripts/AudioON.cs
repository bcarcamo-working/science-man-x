using UnityEngine;
using System.Collections;

public class AudioON : MonoBehaviour {

    public AudioSource audio1;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        audio1.Play();
    }
}
