using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//DETECTA SI SE TOCA O SE SUELTA LO QUE ESTE IMPLEMENTANDO ESTE SCRIP(DONDE LO PONGA)
//para android hay que implementar esas intefaces, down se pulsa, up se deja de tocar
public class Tactiles : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    public static double centro_pantalla = Screen.width / 2.0;
    public static double toque_x;
    public static double toque_y;
    public bool pulsado;
    public bool puente;
    public bool puente2;
    public bool una = true;

    private void Start()
    {
         una = true;
        }
        //pulsado
    public void OnPointerDown(PointerEventData eventData)
    {
       
        toque_x= eventData.position.x;
        toque_y = eventData.position.y;

        pulsado = true;
        puente = true;
        puente2 = false;
   }

    //suelto
    public void OnPointerUp(PointerEventData eventData)
    {
        if (una == true)
        {

            puente2 = true;
            una = false;
        }
        pulsado = false;
        
    }

}
