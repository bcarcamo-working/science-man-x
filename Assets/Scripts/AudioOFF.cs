using UnityEngine;
using System.Collections;

public class AudioOFF : MonoBehaviour {

    public AudioSource audio1;
    public GameObject MainCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        audio1.Pause();
    }
}
