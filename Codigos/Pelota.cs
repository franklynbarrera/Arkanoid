using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {
    //public para cambiarla desde el inspector
    public Rigidbody rig;
    public Tactiles pantalla, boton_sacar;
    public float velocidad_ini = 600f;
    bool en_juego = false;
    Vector3 respaldo_pos_inicial;
    //public para meter todo por fuera
    public  Transform barra;

    /**En awake obtendremos referencias a otros metodos
     * a diferencia del star este se ejecuta primero**/
    /*
   void Awake()
   {
       //intenta buscar un componente del tipo <T> "lo que le coloque". busca sobre donde se ponga el scrip
       rig = GetComponent<Rigidbody>();

        //le asigno la referencia. le digo busque el transfor de mi padre
        barra = GetComponentInParent<Transform>();

   }*/
    // para inicializar
    void Start()
    {
        respaldo_pos_inicial = transform.position;
    }
    public void Detener_movimiento()
    {
        rig.isKinematic = true;
        //se inicializa la velocidad de rigibody ya que si no cuando resetee tendra la misma velocidad q teniaantes del reseteo
        rig.velocity = Vector3.zero;
        //pantalla.puente = false;
        //boton_sacar.puente2 = false;
        //vector 0 es todo a 0 ... (0,0,0)

    }
    public void Resetear()
    {

        transform.position = respaldo_pos_inicial;
        //reseteo su padre para que eljuego se resetee y la pelota vuelva a ser hija de labarra y este encima de ella
        transform.SetParent(barra);
        en_juego = false;
        Detener_movimiento();
    }


    // Update is called once per frame
    void Update () {
        //down es cuando se pulsa, up es cuando se suelta. getbutton es mientras esta presionado
		if(en_juego==false && (Input.GetButtonDown("Fire1")) ||pantalla.puente2==true||boton_sacar.puente2==true)
        {
            pantalla.puente2 = false;
            boton_sacar.puente2 = false;
            en_juego = true;
            /*AL moverse la pelota quier que deje de ser hija de la barra para que la pelota
             pueda despegarse de ella, entomces le quito al papa*/
            transform.SetParent(null);
            /*para que actue por fisica, y deje de actuar con la barra*/
            rig.isKinematic = false;
           // rig.useGravity = true;
            rig.AddForce(new Vector3(velocidad_ini, velocidad_ini,0));
        }
	}
}
