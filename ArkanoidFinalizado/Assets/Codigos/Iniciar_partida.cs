using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar_partida : MonoBehaviour {

    public Tactiles tactil,boton, creditos;

    public Tactiles boton_salir, boton_atras;
    // Update is called once per frame
    void Update () {
        if (boton_atras.pulsado == true)
        {

            Debug.Log("para atras con el boton");


            SceneManager.LoadSceneAsync("Portada", LoadSceneMode.Single);

        }
        if (boton_salir.pulsado == true)
        {

            Debug.Log("SALIOO POR BOTOM");
            Application.Quit();

        }

        if (creditos.pulsado == true){


              SceneManager.LoadSceneAsync("Creditos", LoadSceneMode.Single);
            Debug.Log("creditos"); ;

        }
        if (Input.GetButtonDown("Fire1")||tactil.puente2==true)
        {
            tactil.puente2 = false;
            boton.puente2 = false;


            /*si quiero que cuando le de escape, luego entre a nivel 1 deje de reiniciarse vidas y puntos
             ps lo quito*/
            Vidas.con_vidas = 3;
            Puntos.puntos = 0;

            SceneManager.LoadSceneAsync("Nombre", LoadSceneMode.Single);
            //Application.LoadLevel("Nivel 1");

        }	
	}
}
