using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirDisparo : MonoBehaviour
{
    private float limiteInferior = -70;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < limiteInferior)
        {
            Destroy(gameObject);
        }
    }
}
