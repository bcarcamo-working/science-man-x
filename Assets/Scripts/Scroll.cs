using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
  
    public float velocidad = 0f;
    private bool enMovimiento = true;
 

    // Use this for initialization
    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
       
     
	
	}

    void PersonajeHaMuerto()
    {
        enMovimiento = false;
    }
	
	// Update is called once per frame
	void Update () {
   

        if (enMovimiento)
        {
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * velocidad, 0);
           
     
        }
    }
}
