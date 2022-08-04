using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirEscena : MonoBehaviour
{
    private Vector3 inicialPos;
    private float repetirLargo;

    private void Start()
    {
        inicialPos = transform.position; // Establecer la posición inicial predeterminada
       
        repetirLargo = GetComponent<BoxCollider>().size.x; // Establezca el ancho de repetición en la mitad del fondo
    }

    private void Update()
    {
        // Si el fondo se mueve a la izquierda por su ancho de repetición, muévalo de nuevo a la posición inicial
        if (transform.position.y  > inicialPos.y + 100)
        {
            transform.position = new Vector3(inicialPos.x, inicialPos.y+50, inicialPos.z);
        }
    }
}
