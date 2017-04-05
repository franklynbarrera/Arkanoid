using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir_arriba : MonoBehaviour {



    public Vidas_dobles vida;
    public Sonido_pelo_piso soni;
    public Tactiles tac, boton_salir;

    
    private void OnCollisionEnter(Collision collision)
    {
        tac.una = true;
        boton_salir.una = true;
        soni.sonido.Play();
        vida.Perder_vidas();

    }

    
        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
