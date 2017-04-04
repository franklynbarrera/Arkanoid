using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doble_barra : MonoBehaviour {
    public Tactiles boton_iz, boton_der;
    public float velocidad = 0.4f;
    Vector3 respaldo_pos_inicial;
    int cont = 0;
    bool key = false;
    public int init;

    // Use this for initialization
    void Start()
    {
        respaldo_pos_inicial = transform.position;
    }

    public  void Resetear()
    {

        transform.position = respaldo_pos_inicial;
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == init || key == true)
        {

            cont = 0;
            key = true;

            float dir;
            if (boton_iz.pulsado)
            {//izquierda
                dir = -1;

            }
            else if (boton_der.pulsado)
            {//derecha
                dir = 1;

            }
            else
            {

                dir = Input.GetAxisRaw("Horizontal");
            }

            /*lo inicializo asi por q si lo pongo en 0 me manda a las posicion 0 cuando suelto las flechas
             y ya no es ni 1 ni -1 y me manda a las posicion 0 por no moverme*/
            float pos_x = transform.position.x;
            //izquierda y validacion de pared izquierda

            if (dir == -1 && transform.position.x >= -18.39)
            {
                /*velocidad*Time.deltaTime  es por que si no se hace velocidad por segundo, entonces con este se hace
                 * por cada fotograma, por cada espacio(cuadrito)  ya que el update se llama muy seguido y entonces
                 * la barra pasaria volando */

                /*Time.deltaTime contiene el tiempo que a durado un solo fotograma 
                 lo probe sin time.deltatime y pasa ---------- volando, mientras que con esto 
                 es mas movimiento tipo java que era suave. esto se debe a que update se llama muchisimas
                 veces por segundo y esto se aplica muchisimo. con time.delta time no sucede eso*/
                pos_x = transform.position.x - (velocidad * Time.deltaTime);



            }
            //derecha y validacion de pared derecha
            if (dir == 1 && transform.position.x <= 18.24)
            {
                /*Time.deltaTime contiene el tiempo que a durado un solo fotograma */
                pos_x = transform.position.x + (velocidad * Time.deltaTime);

            }


            /*entonces ahora mi nueva posicion va a ser el movimiento en X y los Y y Z que ya se tenian
             * como update se llama a cada rato, y posX se esta modificando apenas presiono tecla para mover en horizontal
             * entonces cambia pos_x y al actualizar el transfor se hace el efecto de moverse */
            transform.position = new Vector3(pos_x, transform.position.y, transform.position.z);

        }
        else
        {
            cont++;
        }
       
    }
}
