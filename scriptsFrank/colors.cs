using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colors : MonoBehaviour {

    public Color colorStart;// = Color.red;
    public Color colorEnd;// = Color.green;
    public Color colorStart2;// = Color.gray;
    public Color colorEnd2;// = Color.magenta;
    public float duration = 1.0F;
    public Renderer rend;
    int dir=0;
    int cont = 25;
    bool s = true;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (cont == 25)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            if (dir == 0)
            {
                rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
                dir = 1;
            }
            else if (dir == 1)
            {
                rend.material.color = Color.Lerp(colorStart2, colorEnd2, lerp);
                dir = 0;
            }

            cont = 0;
        }
        else
            cont++;
	}
}
