using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_pause : MonoBehaviour {
    public Tactiles boton_sonido, boton_sonido_pause,boton_sonido_hijo,boton_pause_hijo;
    public AudioSource sonido_fondo;
    // Update is called once per frame
    void Update () {


        if (boton_sonido.pulsado == true||boton_sonido_hijo.pulsado==true)
        {

            sonido_fondo.Pause();
            
            boton_sonido.gameObject.SetActive(false);
            boton_sonido_pause.gameObject.SetActive(true);
            boton_sonido.pulsado = false;
            boton_sonido_hijo.pulsado = false;
        }

        if (boton_sonido_pause.pulsado == true||boton_pause_hijo.pulsado==true)
        {
            sonido_fondo.Play();
           
            boton_sonido.gameObject.SetActive(true);
            boton_sonido_pause.gameObject.SetActive(false);
            boton_sonido_pause.pulsado = false;
            boton_pause_hijo.pulsado = false;


        }



    }
}
