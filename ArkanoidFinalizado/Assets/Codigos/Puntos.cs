using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    public static int puntos = 0;
    public Text texto;
    public GameObject niver_completado;
    public GameObject juego_completado;
    public Siguiente_nivel siguiente_nivel;
    public Pelota pelota;
    public barra bar;
    public Sonidos_fin_partida sonido_pasar_nivel;


    /*Trasfor no solo se encarga de rotacion,posicion y escala
     tambien se encarga de ver larelacion entre padre e hijo
     saber cuantos hijos tiene etc*/

    public Transform contenerdor_bloques;

	void Start () {
        Actualizar_texto();
        	
	}

    public void Actualizar_texto()
    {

        texto.text = "Puntos: " + Puntos.puntos;
    }

    public void Sumar_puntos()
    {
        Puntos.puntos++;
        Actualizar_texto();


        //si el numero de hijos del "bloque que es papa de todos los veintipico" es 0 ya parti todo
        if (contenerdor_bloques.childCount <= 0)
        {
            pelota.Detener_movimiento();
            bar.enabled = false;

            if (siguiente_nivel.Es_ultimo_nivel())
            {
                pelota.enabled = false;
                juego_completado.SetActive(true);

                //hacer que suene el fin de nivel
                sonido_pasar_nivel.Nivel_completado();
                

            }
            else
            {
                //hacer que suene el fin de nivel
                sonido_pasar_nivel.Nivel_completado();
                niver_completado.SetActive(true);
            }

            siguiente_nivel.cargar_level();

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
