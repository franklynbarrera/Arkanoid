using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Seleccionar_Nivel : MonoBehaviour {

   public Tactiles nivel1, nivel2, nivel3, nivel4, jefe1,nivel5, nivel6,jefe2, nivel7,nivel8,nivel9,
        nivel10, niveljefeFinal;
   public int viditas=3,puntos_0=0;
	// Update is called once per frame
	void Update () {
        if (nivel1.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 1", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }
        if (nivel2.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 2", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }
        if (nivel3.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 3", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }
        if (nivel4.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 4", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }


        if (jefe1.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Jefe 1", LoadSceneMode.Single);
            Vidas.con_vidas = 10;
            Puntos.puntos = 0;
        }
        if (nivel5.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 5", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }

        if (nivel6.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 6", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }

        if (jefe2.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Jefe 2", LoadSceneMode.Single);
            Vidas.con_vidas = 10;
            Puntos.puntos = 0;
        }

        if (nivel7.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 8", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }

        if (nivel8.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 9", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }

        if (nivel9.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 10", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }

        if (nivel10.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Nivel 11", LoadSceneMode.Single);
            Vidas.con_vidas = viditas;
            Puntos.puntos = 0;
        }
        
        if (niveljefeFinal.pulsado == true)
        {
            SceneManager.LoadSceneAsync("Jefe 3", LoadSceneMode.Single);
            Vidas.con_vidas = 15;
            Puntos.puntos = 0;
        }

    }
}
