using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

    public static int con_vidas=3;
    public Sonidos_fin_partida sonidofin_partida;
    public Text texto;
    public Pelota pelo;
    public barra barra;
    public GameObject game_over;
    public Siguiente_nivel pasar_nivel;
    // Use this for initialization
    void Start () {
        Actualizar_texto();
	}

    public void pierda()
    {

       // //activo sonido de game over
     //   sonidofin_partida.Game_over();
        //activar mensaje de game over
        game_over.SetActive(true);
        pelo.Detener_movimiento();

        pelo.enabled = false;

        //desactivar el scrip barra q se encarga de el movimientos
        barra.enabled = false;
        pasar_nivel.nombre_nivel = "Portada";
        pasar_nivel.cargar_level();

    }

    public void Actualizar_texto()
    {


        texto.text = "Vidas: " + Vidas.con_vidas;
    }
	
    public void Perder_vidas()
    {
        if (Vidas.con_vidas <= 0)
        {
            return;
        }
        Vidas.con_vidas--;
        Actualizar_texto();
        
        if (Vidas.con_vidas <= 0)
        {
            //activo sonido de game over
            sonidofin_partida.Game_over();
            //activar mensaje de game over
            game_over.SetActive(true);
            pelo.Detener_movimiento();

            pelo.enabled = false;
           
            //desactivar el scrip barra q se encarga de el movimientos
            barra.enabled = false;
            pasar_nivel.nombre_nivel = "Portada";
            pasar_nivel.cargar_level();

        }
        else{

            
        barra.Resetear();

            
        pelo.Resetear();


        }
    }
	
}
