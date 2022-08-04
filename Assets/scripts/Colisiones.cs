using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    public int damage = 50;
    public int vidaEnemigo = 100;
    public GameObject life;
    public GameObject life2;
    public GameObject explosion;
    public GameObject explosionNave;

    public AudioClip disparo;
    private AudioSource audiobala;

    void Start()
    {
        audiobala = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Bala"))
        {
            Debug.Log(vidaEnemigo);
            vidaEnemigo -= damage;



            if (vidaEnemigo <= 0)
            {
                int aleatorio = Random.Range(1, 4);
                if (aleatorio == 1) 
                {
                    Instantiate(life, transform.position, life.transform.rotation);
                }else if (aleatorio == 2) 
                {
                    Instantiate(life2, transform.position, life2.transform.rotation);
                }
                
                Destroy(gameObject);
                Instantiate(explosionNave, transform.position, explosionNave.transform.rotation);
                audiobala.PlayOneShot(disparo, 0.5f);


            }
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            audiobala.PlayOneShot(disparo, 0.5f);

        }


    }
}
