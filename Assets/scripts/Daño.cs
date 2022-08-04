using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Da�o : MonoBehaviour
{
    public int damage = 50;
    public int vidaEnemigo = 100;
    public GameObject Enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemigo") 
        {
            Debug.Log(damage);
            vidaEnemigo -= damage;
         
        }

        if (vidaEnemigo <=0) 
        {
            Destroy(gameObject);
        }

    }
}
