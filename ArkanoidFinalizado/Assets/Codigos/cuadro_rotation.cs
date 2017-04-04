using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadro_rotation : MonoBehaviour {

    float position = 0;
    float position_z = 0;
    public float speed =  5;
    int status = 1;
    int cont = 0;
    public Pelota pel;
    bool entra = false;
	// Update is called once per frame
	void Update () {

        if (entra == false)
        {
            Invoke("Entrar", 3);

        }



        if (entra == true) {float W = 10;
        if (position_z < 360)
        {
            position_z+=10;
        }
        else if (position_z == 360)
        {
            position_z=-360;
            W = 10;
        }

        transform.rotation = new Quaternion(0, 0, transform.position.y, position_z); }
        
	}

    void Entrar()
    {

        entra = true;
    }
}