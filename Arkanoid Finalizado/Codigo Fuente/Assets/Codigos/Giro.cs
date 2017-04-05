using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour {

    bool pase = false;
	// Update is called once per frame
	void Update () {

        if (pase == false)
        {

            Invoke("Entrar", 1);
        }

        if (pase == true)
        {


        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
        }
		
	}

    void Entrar()
    {

        pase = true;

    }
}
