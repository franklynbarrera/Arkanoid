using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool salir;
    // Update is called once per frame
   
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("salio");

                Application.Quit();
            }
            else
            {

                //IR A LA ESCENA QUE SE LLAMA PORTADA EL NOMBRE DEBE SER IGUAL AL DE UNITY DE MI ESCENA

                SceneManager.LoadSceneAsync("Portada", LoadSceneMode.Single);
                
                
            }



        }

        //si quiero clave para reiniciar todo a valores por defecto
        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("holi");
            Vidas.con_vidas = 3;
            Puntos.puntos = 0;



        }*/
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("salise");

        Application.Quit();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("soltaste salir");
    }
}
