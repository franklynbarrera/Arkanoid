using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public Vidas vida;
    public Sonido_pelo_piso soni;
    public Tactiles tac,boton_salir;
    private void OnTriggerEnter(Collider other)
    {
        tac.una = true;
        boton_salir.una = true;
        soni.sonido.Play(); 
        vida.Perder_vidas();

    }
}
