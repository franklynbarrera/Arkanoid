using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos_fin_partida : MonoBehaviour {

    public AudioSource varios_audios;
    public AudioClip completado;
    public AudioClip game_over;
   
    public void Game_over()
    {
        reproducir(game_over);

    }


    public void Nivel_completado()
    {

        reproducir(completado);
    }

    

    void reproducir(AudioClip a)
    {

        //al audio source se le iguala el clip y asi le meto el sonido
        varios_audios.clip = a;
        varios_audios.loop = false;
        varios_audios.Play();

    }


}
