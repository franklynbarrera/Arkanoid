using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Empezar_juego : MonoBehaviour {

    public Tactiles jugar;
    public NombreJug jugador;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //jugador.enviarNombreJug();
        if (jugar.pulsado == true){

            jugador.enviarNombreJug();
        SceneManager.LoadSceneAsync("Nivel 1", LoadSceneMode.Single);
        }


    }
}
