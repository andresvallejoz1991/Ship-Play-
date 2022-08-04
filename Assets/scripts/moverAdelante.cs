using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverAdelante : MonoBehaviour
{
    public float Velocidad = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Velocidad * Time.deltaTime);
    }
}
