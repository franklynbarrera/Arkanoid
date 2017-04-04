using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausar_partida : MonoBehaviour {

    public Tactiles boton_pausa,boton_seguir;
    public GameObject luz, luz_col_izq, luz_col_der, luz_techo;
    public Text texto_pausa;
    public bool en_pausa = false;
    
    // Update is called once per frame
    void Update () {

        if (boton_pausa.pulsado == true)
        {
            en_pausa = true;
            texto_pausa.gameObject.SetActive(true);
            luz.GetComponent<Light>().gameObject.SetActive(false);

            //PRENDER LUCES DE ESTRUCTURA AL PAUSAR
            luz_col_der.GetComponent<Light>().gameObject.SetActive(true);
            luz_col_izq.GetComponent<Light>().gameObject.SetActive(true);
            luz_techo.GetComponent<Light>().gameObject.SetActive(true);


            boton_pausa.pulsado = false;

            boton_pausa.gameObject.SetActive(false);
            boton_seguir.gameObject.SetActive(true);
            if (Time.timeScale == 1)
            {    //si la velocidad es 1
                Time.timeScale = 0;     //que la velocidad del juego sea 0
            }
           
            

        }

        if (boton_seguir.pulsado == true)
        {
            en_pausa = false;
            texto_pausa.gameObject.SetActive(false);
            luz.GetComponent<Light>().gameObject.SetActive(true);
            boton_seguir.pulsado = false;


            //APAGAR LUCES DE ESTRUCTURA AL PAUSAR
            luz_col_der.GetComponent<Light>().gameObject.SetActive(false);
            luz_col_izq.GetComponent<Light>().gameObject.SetActive(false);
            luz_techo.GetComponent<Light>().gameObject.SetActive(false);


            boton_pausa.gameObject.SetActive(true);
            boton_seguir.gameObject.SetActive(false);
            if (Time.timeScale == 0)
            {   // si la velocidad es 0
                Time.timeScale = 1;     // que la velocidad del juego regrese a 1
            }

        }


    }
}
