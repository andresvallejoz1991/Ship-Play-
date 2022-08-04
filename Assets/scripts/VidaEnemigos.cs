using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    public int vidaEnemigo;
   
    private void Update()
    {
        Debug.Log(vidaEnemigo);
        if (vidaEnemigo == 0) 
        {
            Destroy(gameObject);
        }
        
    }
}
