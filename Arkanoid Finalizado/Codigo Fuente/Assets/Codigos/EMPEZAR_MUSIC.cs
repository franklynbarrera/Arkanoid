using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPEZAR_MUSIC : MonoBehaviour {

    public AudioSource musica;
	// Use this for initialization
	void Start () {

        Invoke("Empezar", 1);
	}

    void Empezar()
    {

        musica.Play();

    }
	
	
}
