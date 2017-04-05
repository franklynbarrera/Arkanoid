using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos_pelotas : MonoBehaviour {
    public AudioSource rebote_paredes;
    public AudioSource partir_bloque;
    private void OnCollisionEnter(Collision collision)
    {

        /*accedo al objeto con quien colisione para saber cual fue
        para eso se le ponen etiquetas a los gameobjet
        dichas etiquetas se llaman tag. entonces le digo al gameobject que compare el tag
        a ver si el tag del objeto con quien colisiono es el que quiero buscas
        dependiendo de con quien sea realizo mi tarea*/
        
       if(collision.gameObject.CompareTag("Bloque"))
        {

            partir_bloque.Play();

        }else //si tuviese mas objetos por diferenciar para mas sonido entonces quito este else por otro if y hago mas tag a los objetos con quien quiera ver la colisoom
        {
            rebote_paredes.Play();


        }

    }
}
