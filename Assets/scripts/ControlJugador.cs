using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 10;
    public float entradaHorizontal;
    public GameObject balaPrefabP;
    private float t_espera = 1.0f;
    private float t_proyectil = 0.0f;

    public AudioClip disparo;
    private AudioSource audiobala;


    // Start is called before the first frame update
    void Start()
    {
        audiobala = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");
        if (transform.position.x < -38)
        {
            transform.position = new Vector3(-38, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 38)
        {
            transform.position = new Vector3(38, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.left * velocidad * Time.deltaTime * entradaHorizontal);
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > t_proyectil)
        {
            t_proyectil = Time.time + t_espera;
            Instantiate(balaPrefabP, transform.position, balaPrefabP.transform.rotation);
            audiobala.PlayOneShot(disparo, 0.5f);
        }
    }
}
