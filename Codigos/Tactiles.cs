using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//DETECTA SI SE TOCA O SE SUELTA LO QUE ESTE IMPLEMENTANDO ESTE SCRIP(DONDE LO PONGA)
//para android hay que implementar esas intefaces, down se pulsa, up se deja de tocar
public class Tactiles : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool pulsado;
    public bool puente;
    public bool puente2;
    public bool una = true;

    //pulsado
    public void OnPointerDown(PointerEventData eventData)
    {
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
