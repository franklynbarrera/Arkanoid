using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barra_movimiento : MonoBehaviour {

    int  dir = -1;
    public float speed = 7f;
    bool pase = false;
	// Update is called once per frame
	void Update () {
        if (pase == false)
        {
 Invoke("Entrar", 3);

        }
       
        if (pase == true)
        {
                 float pos_x = transform.position.x;

                        if (dir == 1 && transform.position.x < 6)
                            pos_x = (transform.position.x) + (speed * Time.deltaTime);
                        else  if (dir == -1 && transform.position.x > -6)
                            pos_x = (transform.position.x) - (speed * Time.deltaTime);
                        else
                            dir *= (-1);
            
                        transform.position = new Vector3(pos_x,transform.position.y,transform.position.z);

        }
       
	}


    void Entrar()
    {

        pase = true;
    }
}
