using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Bailarin_colision : MonoBehaviour {
    public GameObject bloques;
    public Siguiente_nivel sig;
    public GameObject efecto_particulas;
    public AudioSource grito;
    public Text completa;
    public GameObject [] vidas_franklyeitor;
    int con = 0;
    public GameObject luz;
    bool primera_vez = false;
    public Pelota pelo;
    public doble_barra bar;
    public doble_barra aba;

    bool entra = false;
    public Animator anim;
    public GameObject robot;
    private //void  OnTriggerEnter(Collider other)
    void OnCollisionEnter(Collision collision)
    {
        float a= collision.gameObject.transform.position.x;
        float b = collision.gameObject.transform.position.y;
        float a1 = robot.transform.position.x;
         pelo.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        Debug.Log("colison en x: "+ a);
        Debug.Log("POSICION DEL ROBOT: " + a1);
        entra= false;
        
        /*Arriba*/
        if (a >= (robot.transform.position.x-0.99) && a <= transform.position.x && b>=(transform.position.y-2.20))
        {
            pelo.GetComponent<Rigidbody>().AddForce(new Vector3(-400f, 500f, 0f));
            entra = true;

        }else if(a <= (robot.transform.position.x + 0.99)&& a >= transform.position.x&&b >= (transform.position.y - 2.20))
        {
            pelo.GetComponent<Rigidbody>().AddForce(new Vector3(400f, 500f, 0f));
            entra = true;
        }

        if (entra == false)
        {
            if (a >= a1)
            {
                Debug.Log("LA MANDE POR DERECHA");
                pelo.GetComponent<Rigidbody>().isKinematic = true;

                pelo.GetComponent<Rigidbody>().isKinematic = false;
                pelo.GetComponent<Rigidbody>().velocity = Vector3.zero;


                pelo.GetComponent<Rigidbody>().AddForce(new Vector3(600f, 600f, 0f));

                //pelo.transform.position = new Vector3(pelo.transform.position.x, pelo.transform.position.y, 0);
            }
            else if (a < a1)
            {
                Debug.Log("LA MANDE POR IZQUIERDA");
                pelo.GetComponent<Rigidbody>().isKinematic = true;
                pelo.GetComponent<Rigidbody>().isKinematic = false;
                pelo.GetComponent<Rigidbody>().velocity = Vector3.zero;
                 pelo.GetComponent<Rigidbody>().AddForce(new Vector3(-600f, -600f, 0f));

                }
            

        }

        if (con <= 14)
        {

                Destroy(vidas_franklyeitor[con]);
                Instantiate(efecto_particulas, vidas_franklyeitor[con].transform.position, Quaternion.identity);
                con++;

        }

        if (con == 15){
            pelo.Detener_movimiento();
            bar.enabled = false;
            aba.enabled = false;

            anim.Play("New State");
            completa.gameObject.SetActive(true);
            Invoke("Seguir", 3);
            

        }

        
        grito.Play();
        if (primera_vez == false)
        {
         luz.GetComponent<Light>().gameObject.SetActive(true);
        Invoke("block", 3);
            primera_vez = true;

        }else
        {
            luz.GetComponent<Light>().gameObject.SetActive(true);
            Invoke("activar_lista", 3);
            Invoke("Apagar_sayayin", 3);

        }
       
       // Debug.Log("me toco guapo");
    }

    public void Seguir()
    {

        completa.gameObject.SetActive(false);
        sig.nombre_nivel = "Portada";
        sig.cargar_level();
        //SceneManager.LoadSceneAsync("Portada", LoadSceneMode.Single);
        Debug.Log("GANOOO");

    }
    public void block() {

        luz.GetComponent<Light>().gameObject.SetActive(false);
        bloques.SetActive(true);

    }

    public void Apagar_sayayin() {


        luz.GetComponent<Light>().gameObject.SetActive(false);
    }

    public void activar_lista()
    {
        /*
        foreach (GameObject lis in Bloques.lista_parti)
        {
            //print(.name + " " + guy.power);
            Destroy(lis);
        }
        foreach (GameObject lis in Bloques_dobles.lista_parti)
        {
            //print(.name + " " + guy.power);
            Destroy(lis);
        }

        */

        foreach (GameObject lis in Bloques_dobles.lista_segunda_capa)
        {
            //print(.name + " " + guy.power);
            lis.SetActive(false);
        }


        foreach (GameObject lis in Bloques_dobles.lista)
        {
            //print(.name + " " + guy.power);
          lis.SetActive(true);
        }
    
     /*
        foreach (GameObject lis in Bloques.lista)
        {
            //print(.name + " " + guy.power);
            lis.SetActive(true);
        }
       */ 
    }

}
