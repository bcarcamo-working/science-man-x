using UnityEngine;
using System.Collections;

public class MoverCamara : MonoBehaviour {
    public GameObject MainCamera;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   void OnMouseDown()
    {
        MainCamera.transform.Translate(new Vector3(17.55f, 0, 0));
    }
}
