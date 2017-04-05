using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public Vidas vida;
    public Sonido_pelo_piso soni;
    public Tactiles tac,boton_salir;
    public Pelota[] p = new Pelota[1];
    public barra b;

    private void OnTriggerEnter(Collider other)
    {
       
        if (b.level != "nivel06")
        {
            tac.una = true;
            boton_salir.una = true;
            soni.sonido.Play();
            vida.Perder_vidas();
        }
        else
        {
            if (other.gameObject == p[0].gameObject)
            {
                p[0].transform.position = new Vector3(p[0].transform.position.x, -15, p[0].transform.position.z);
                p[0].enabled = true;
                p[0].Detener_movimiento();
            }
            else if (other.gameObject == p[1].gameObject)
            {
                p[1].transform.position = new Vector3(p[1].transform.position.x, -15, p[1].transform.position.z);
                p[1].enabled = true;
                p[1].Detener_movimiento();
            }
            else
            {
                tac.una = true;
                boton_salir.una = true;
                soni.sonido.Play();
                vida.Perder_vidas();
            }
        }


    }
}
