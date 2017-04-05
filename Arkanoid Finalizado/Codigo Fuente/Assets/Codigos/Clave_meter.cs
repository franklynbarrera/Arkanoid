using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clave_meter : MonoBehaviour {

    public Light luz_techo,luz_fondo;
    public Tactiles pencil, aceptar,cancelar;
    public InputField clave;
    public Text indicador,correcta,incorrecta;
    public AudioSource music_fondo;
    public AudioSource perdio, aplausos;
    public Text texto_juego_completado;
    /*Dar 10 vidas*/
    string clave1="epale chamo dame vidas";
    string roraima = "roraima";

    /*Perder automaticamente*/
    string clave2 = "yeltsin";
    string clave3 = "edgar";
    string clave4 = "ramon";
    string clave5 = "jefferson";
    string clave6 = "francisco";
    string clave7 = "kevin";
    string clave8 = "javier";
    string clave9 = "neptaly";
    string clave10 = "jesus";
    string clave11 = "marcos";
    string clave12 = "junior";

    /*Ganar automaticamente*/
    string franklyn = "franklyn";
    string prof2 = "miguelito";
    string clavell = "vieja loca";

    /*Dar 1000 vidas*/
    string clavel = "clavel";
    string norvelis = "norvelis";
    string prof = "miguel useche";
    string yo = "franklyn barrera";
    
    

    public Text texto;
    public Vidas vi;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (pencil.pulsado == true)
        {
            Debug.Log("Entra");
            clave.gameObject.SetActive(true);
            indicador.gameObject.SetActive(true);
            aceptar.gameObject.SetActive(true);
            cancelar.gameObject.SetActive(true);
            Pausa_escena();
          


        }

        if (aceptar.pulsado == true)
        {
            /*Dar 10 vidas*/
            if (clave.text.ToLower() == clave1.ToLower()|| clave.text.ToLower() == roraima.ToLower())
            {

                             //Debug.Log("Sirviooooo");
                             Vidas.con_vidas+=10;
                             texto.text = "Vidas: " + Vidas.con_vidas;
                indicador.gameObject.SetActive(false);
                correcta.gameObject.SetActive(true);
                Seguir_escena();
                Invoke("Desactivar_letrero", 2);


                /*Perder automaticamente*/
            }
            else if (clave.text.ToLower() == clave2.ToLower()|| clave.text.ToLower() == clave3.ToLower()||
                        clave.text.ToLower() == clave4.ToLower()|| clave.text.ToLower() == clave5.ToLower()
                        || clave.text.ToLower() == clave6.ToLower()|| clave.text.ToLower() == clave7.ToLower()||
                        clave.text.ToLower() == clave8.ToLower()|| clave.text.ToLower() == clave9.ToLower()||
                       clave.text.ToLower() == clave10.ToLower()|| clave.text.ToLower() == clave11.ToLower()||
                        clave.text.ToLower() == clave12.ToLower())
            {
                music_fondo.Pause();
                perdio.Play();
                Vidas.con_vidas = 0;
                texto.text = "Vidas: " + Vidas.con_vidas;
                vi.pierda();
                indicador.gameObject.SetActive(false);
                correcta.gameObject.SetActive(true);
                Seguir_escena();
                Invoke("Desactivar_letrero", 2);


                /*Ganar automaticamente*/
            }
            else if(clave.text.ToLower() == franklyn.ToLower()|| clave.text.ToLower() == prof2.ToLower()
                || clave.text.ToLower() == clavell.ToLower() )
            {

                texto_juego_completado.gameObject.SetActive(true);
                music_fondo.Pause();
                aplausos.Play();
                Seguir_escena();
                Invoke("Final", 3);



                /*Dar 1000 vidas*/
            }
            else if (clave.text.ToLower() == norvelis.ToLower()|| clave.text.ToLower() == prof.ToLower()
                || clave.text.ToLower() == clavel.ToLower() || clave.text.ToLower() == yo.ToLower())
            {
                
                Vidas.con_vidas += 1000;
                texto.text = "Vidas: " + Vidas.con_vidas;
                indicador.gameObject.SetActive(false);
                correcta.gameObject.SetActive(true);
                Seguir_escena();
                Invoke("Desactivar_letrero", 2);

            }
            else
            {
                indicador.gameObject.SetActive(false);
                incorrecta.gameObject.SetActive(true);
                Seguir_escena();
                Invoke("Desactivar_letrero2", 2);

            }

        }
        if (cancelar.pulsado == true)
        {

            pencil.pulsado = false;
            pencil.una = true;
            cancelar.pulsado = false;
            cancelar.una = true;
            aceptar.pulsado = false;
            aceptar.una = true;

            Seguir_escena();

            clave.gameObject.SetActive(false);
            indicador.gameObject.SetActive(false);
            aceptar.gameObject.SetActive(false);
            cancelar.gameObject.SetActive(false);

        }



        

	}

    public void Final()
    {
        texto_juego_completado.gameObject.SetActive(false);
        aplausos.Pause();
        SceneManager.LoadSceneAsync("Portada", LoadSceneMode.Single);

    }

   public  void Pausa_escena()
    {

        luz_techo.GetComponent<Light>().gameObject.SetActive(true);
        luz_fondo.GetComponent<Light>().gameObject.SetActive(false);
        if (Time.timeScale == 1)
        {    //si la velocidad es 1
            Time.timeScale = 0;     //que la velocidad del juego sea 0
        }

    }


   public  void Desactivar_letrero()
    {
      

        
         correcta.gameObject.SetActive(false);
        Invoke("Seguir_escena",1);

        

    }
   public void Desactivar_letrero2()
    {

        Debug.Log("saqueloo");
        incorrecta.gameObject.SetActive(false);
        Invoke("Seguir_escena", 1);

    }
    public void Seguir_escena()
    {
       
        pencil.pulsado = false;
        pencil.una = true;
        cancelar.pulsado = false;
        cancelar.una = true;
        aceptar.pulsado = false;
        aceptar.una = true;


        clave.text = "";
        clave.gameObject.SetActive(false);
        indicador.gameObject.SetActive(false);
        aceptar.gameObject.SetActive(false);
        cancelar.gameObject.SetActive(false);

        luz_techo.GetComponent<Light>().gameObject.SetActive(false);
        luz_fondo.GetComponent<Light>().gameObject.SetActive(true);
        if (Time.timeScale == 0)
        {   // si la velocidad es 0
            Time.timeScale = 1;     // que la velocidad del juego regrese a 1
        }



    }
}
