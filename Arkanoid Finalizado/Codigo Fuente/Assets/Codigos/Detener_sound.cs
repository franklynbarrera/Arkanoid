using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detener_sound : MonoBehaviour {

    public new AudioSource audio;
    private void Awake()
    {
        audio.Pause();
        Invoke("Empezar", 4);
    }

    void Empezar() {

        audio.Play();

    }
}
