using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour {

    public GameObject efecto_particulas;
    
    public Puntos puntos;
    public bool ocultar_bloques_no_borrar=false;
    public static List<GameObject> lista = new List<GameObject>();

    public static List<GameObject> lista_parti = new List<GameObject>();

    public void Start()
    {
        lista_parti = new List<GameObject>();
        lista = new List<GameObject>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("En colision enter");

        /*INSTANCIADOR DE GAME OBJECT asi lo pongo en la escena
         quaternion.identy es para darle a la rotacion que tenga la por defecto*/
         Instantiate(efecto_particulas, transform.position, Quaternion.identity);
        //Destroy(efecto_particulas, .3f);
      //  lista_parti.Add(efecto_particulas);
        /*Destruyo el gameobject en donde este colocado el scrip, en este caso los bloques*/
        if (ocultar_bloques_no_borrar == false)
        {

            Debug.Log("DESRUIDO" + collision);
            Destroy(gameObject);
            transform.SetParent(null);

        }
        if (ocultar_bloques_no_borrar == true)
        {


            gameObject.SetActive(false);
            lista.Add(gameObject);

        }

        /*LE quito su padre para q deje de tener papa y salga de una vez
         si no el se termina de destruir desps de mucho tiempo*/
      //  Invoke("Destruir_particulas", 2);
        puntos.Sumar_puntos();   
    }

    public void Destruir_particulas()
    {

        //efecto_particulas.
     //   ParticleSystem.Clear();

        //   DestroyImmediate(efecto_particulas,true);

    }


}
