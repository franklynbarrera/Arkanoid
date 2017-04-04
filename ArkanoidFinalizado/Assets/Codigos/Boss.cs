using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public Pelota ball;
    public float speed = 0.7f;
    private int live = 5;
    public string vida = "10";
    public Siguiente_nivel next;
    public GameObject juego_completado;
    public GameObject nivel_completado;
    public Slider life_Slider;
    public barra barra;
    public string golpe;
    public string morir;
    int cont = 0;
    Animator anim;

    private void OnCollisionEnter(Collision collision)
    {
        anim = GetComponent<Animator>();
        muerto();
        ball.give_force(speed, speed, 0);
        Debug.Log("se dio fuerza");
        live--;
        Debug.Log("vida restante " + live);
        anim.Play(golpe);
        life_Slider.value -= 0.166666F;
        cont = 0;
    }



    void muerto()
    {
        if (live == 0)
        {
            anim.SetBool("muerte", true);
            anim.Play(morir);
            Debug.Log(" SE GANO EL JUEGO");
            ball.Detener_movimiento();
            barra.enabled = false;
            if (next.Es_ultimo_nivel())
            {
                ball.enabled = false;
                juego_completado.SetActive(true);
            }
            else
            {
                nivel_completado.SetActive(true);
            }
            next.cargar_level();
        }
    }

}