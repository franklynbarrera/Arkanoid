using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class agarrar_nom : MonoBehaviour {
    public Text t;
    public Text n; // campo de texto con el nombre del jugador


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
        t.text = "nombre: "+n.text;
	}
}
