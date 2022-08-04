using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoX : MonoBehaviour
{
    /*public float velocidad;
    private Rigidbody enemigoRb;
    private AdministradorSpawnX scriptAdministradorSpawnX;
    
    void Start()
    {
        enemigoRb = GetComponent<Rigidbody>();
        scriptAdministradorSpawnX = GameObject.Find("AdministradorSpawn").GetComponent<AdministradorSpawnX>();
        velocidad = scriptAdministradorSpawnX.velocidadEnemigos;
    }
    
    void Update()
    {
        // Establece la dirección del enemigo hacia el arco del jugador y muéve el enemigo asi alli
        Vector3 direccionBuscar = (ArcoJugador.transform.position - transform.position).normalized;
        enemigoRb.AddForce(direccionBuscar * velocidad * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // Si el enemigo choca con cualquier objetivo, destrúyelo.
        if (other.gameObject.name == "Arco Enemigo")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Arco Jugador")
        {
            Destroy(gameObject);
        }

    }*/

}
