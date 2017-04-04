using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialOne : MonoBehaviour {

    public GameObject efect;
    public Puntos Puntos;
    public Pelota nuevaBola;


    void OnCollisionEnter(Collision col)
    {

        Instantiate(efect, transform.position, Quaternion.identity); // rotacion por defecto
        Destroy(gameObject); // objeto que esta colocado el script
        transform.SetParent(null);
        Puntos.Sumar_puntos();
        Instantiate(nuevaBola, transform.position, Quaternion.identity);

        nuevaBola.gameObject.SetActive(true);
        nuevaBola.mover();
    }

}
