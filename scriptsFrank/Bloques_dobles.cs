using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques_dobles : MonoBehaviour {


    public GameObject efecto_particulas;

    public GameObject segunda_capa;
    public Puntos puntos;
    bool cambiar_de_bloque = true;
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("En colision enter");

        /*INSTANCIADOR DE GAME OBJECT asi lo pongo en la escena
         quaternion.identy es para darle a la rotacion que tenga la por defecto*/
        Instantiate(efecto_particulas, transform.position, Quaternion.identity);
        /*Destruyo el gameobject en donde este colocado el scrip, en este caso los bloques*/
        Destroy(gameObject);
        if (cambiar_de_bloque == true)

        {
            Instantiate(segunda_capa, transform.position, Quaternion.identity);
            segunda_capa.SetActive(true);
            cambiar_de_bloque = false;
        }

        /*LE quito su padre para q deje de tener papa y salga de una vez
         si no el se termina de destruir desps de mucho tiempo*/
        transform.SetParent(null);
        puntos.Sumar_puntos();
    }


}
