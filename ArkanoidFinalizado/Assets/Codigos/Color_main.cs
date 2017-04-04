using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Color_main : MonoBehaviour {

    //public GameObject camara;
   public pausar_partida pausado;
    public Color color2;

    public Color color1 = Color.cyan;
    public Color color3 = Color.gray;
    public float duration = 3.0F;
    bool entra = false;
    new Camera camera;

    void Start()
    {
        
        camera = GetComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
        color2 = camera.backgroundColor;
    }

    void Update()
    {
        if (pausado.en_pausa == true)
        {
            //float t = Mathf.PingPong(Time.time, duration) / duration;
            
            camera.backgroundColor = Color.Lerp(color1, color3, 0);
            entra = true;
        }else if(pausado.en_pausa == false&& entra==true)
        {




            camera.backgroundColor = Color.Lerp(color2, color3, 0);
            entra = false;
        }
       
    }

}
