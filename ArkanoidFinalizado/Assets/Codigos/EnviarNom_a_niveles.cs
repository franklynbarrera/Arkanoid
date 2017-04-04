using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviarNom_a_niveles : MonoBehaviour {


    public Tactiles []botones;
    public NombreJug jugador;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        for(int i = 0; i < botones.Length; i++)
        {

            if (botones[i].pulsado == true)
            {

                jugador.enviarNombreJug();
            }

        }
		
	}
}
