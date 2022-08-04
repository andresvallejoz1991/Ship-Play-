using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionJugador : MonoBehaviour
{
    public int damage = 50;
    public int vidaJugador = 200;
    public GameObject explosion;
    public GameObject explosionNave;

    private AdminApawn gameManagerX;
    

    void Start()
    {
        gameManagerX = GameObject.Find("AdministradorSpawn").GetComponent<AdminApawn>();
    }
    
   

    private void OnTriggerEnter(Collider other)
    {
        if (vidaJugador > 200) 
        {
            vidaJugador = 200;
        }
        if (other.gameObject.CompareTag("BalaEnemy"))
        {
            Debug.Log(vidaJugador);
            vidaJugador -= damage;

            if (vidaJugador <= 0)
            {
                Debug.Log(vidaJugador);
                Destroy(gameObject);
                Instantiate(explosionNave, transform.position, explosionNave.transform.rotation);
                gameManagerX.GameOver();

            }
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, explosion.transform.rotation);

        }

        if (other.gameObject.CompareTag("life")) 
        {
            vidaJugador += 10;
            Destroy(other.gameObject);
            Debug.Log(vidaJugador);
        }

        if (other.gameObject.CompareTag("life2")) 
        {
            vidaJugador += 50;
            Destroy(other.gameObject);
            Debug.Log(vidaJugador);
        }

    }
}
