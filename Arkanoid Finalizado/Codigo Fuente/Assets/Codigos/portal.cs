using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

    GameObject p;
    public Pelota pel;

    private void OnCollisionEnter(Collision other)
    {
        other.transform.position = new Vector3(19.89F,15.15F,0);
        pel.rig.AddForce(500f, 500f, 0);
    }
}
