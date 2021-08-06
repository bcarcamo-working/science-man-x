using UnityEngine;
using System.Collections;

public class Item2 : MonoBehaviour {

    public int puntosGanados = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos2", puntosGanados);
        Destroy(gameObject);

    }
}


