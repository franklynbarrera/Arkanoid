using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Ir_a_nivel : MonoBehaviour
{
    public Tactiles boton;
    public string nivel;

    // Update is called once per frame
    void Update()
    {

        if (boton.pulsado == true)
        {



            SceneManager.LoadSceneAsync(nivel, LoadSceneMode.Single);
        }
    }
}