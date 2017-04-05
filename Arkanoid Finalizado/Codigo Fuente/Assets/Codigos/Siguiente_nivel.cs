using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siguiente_nivel : MonoBehaviour {

    public string nombre_nivel;
    public float tiempo_de_cambio_nivel;
    public Tactiles tac;
    //forzar a que el metodo aparezca en el inspector
    [ContextMenu("cargar_level")]
    public void cargar_level()
    {

        Invoke("Cargar_nivel_sig", tiempo_de_cambio_nivel);
    }

    void Cargar_nivel_sig() {
        if (!Es_ultimo_nivel())
        {
            Vidas.con_vidas++;

        }

        tac.una = true;

        SceneManager.LoadSceneAsync(nombre_nivel, LoadSceneMode.Single);
     //   Application.LoadLevel(nombre_nivel);
    }

    public bool Es_ultimo_nivel()
    {

        if (nombre_nivel == "Portada")
        {
            //Debug.Log("Ultimo");
            return true;
        }else
        {
            return false;

        }

    }
    void Update () {
		
	}
}
