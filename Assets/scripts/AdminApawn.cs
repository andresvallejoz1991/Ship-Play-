using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AdminApawn : MonoBehaviour
{
    private float spawnLimite = 35;
    private float spawnPosY = -15;

    public GameObject enemigoPrefab;
    public GameObject balaEnemy;
    public GameObject powerupPrefab;


    public GameObject player;
    private float spawnIntervalo = 3f;
    public bool esJuegoActivo;
    public GameObject pantallaPrincipal;

    public TextMeshProUGUI gameOverTexto;
    public Button reiniciarBoton;

    public TextMeshProUGUI txtGanaste;
    public TextMeshProUGUI txtSobrevivido;
    public TextMeshProUGUI txtTiempo;
    public TextMeshProUGUI txtVida;
    public Button btnVolveraJugar;

    public ColisionJugador colisionjugador;

    private float tiempo = 60.0f;

    public AudioClip disparo;
    private AudioSource audiobala;

    void Start() {
        audiobala = GetComponent<AudioSource>();
        colisionjugador = GameObject.Find("jugador").GetComponent<ColisionJugador>();
    }


    public void ComenzarJuego(float intervalo)
    {
        spawnIntervalo /= intervalo;
        Debug.Log(spawnIntervalo);
        esJuegoActivo = true;
        StartCoroutine(SpawnObjetivo());
        pantallaPrincipal.SetActive(false);
       
    }

    private void Update()
    {
        if (esJuegoActivo)
        {
            txtTiempo.gameObject.SetActive(true);
            txtVida.gameObject.SetActive(true);
            tiempo = tiempo - Time.deltaTime;



            Debug.Log(tiempo);
            if (tiempo>=0) 
            {
                txtTiempo.text = "Tiempo: " + Mathf.Round(tiempo);
                txtVida.text = "Vida: " + colisionjugador.vidaJugador;
            }
           
        }
    }

    IEnumerator SpawnObjetivo()
    {

        while (esJuegoActivo )
        {
            yield return new WaitForSeconds(spawnIntervalo);

            if (esJuegoActivo && tiempo > 0)
            {
                Instantiate(enemigoPrefab, RandomSpawnPosition(), enemigoPrefab.transform.rotation);
            }
            else if(esJuegoActivo && tiempo < 0)
            {
                txtGanaste.gameObject.SetActive(true);
                txtSobrevivido.gameObject.SetActive(true);
                btnVolveraJugar.gameObject.SetActive(true);
                esJuegoActivo = false;
            }
        }
    }

    Vector3 RandomSpawnPosition()
    { 
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnLimite, spawnLimite), spawnPosY, 3);
        int index = Random.Range(3,20);
        //for (int i = 0; i < index; i++)
        //{
            Instantiate(balaEnemy, spawnPosition, balaEnemy.transform.rotation);
            audiobala.PlayOneShot(disparo,0.5f);

        //}
        return spawnPosition;
    }

    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        //txtGanaste.gameObject.SetActive(false);
        //txtSobrevivido.gameObject.SetActive(false);
        //btnVolveraJugar.gameObject.SetActive(false);
        gameOverTexto.gameObject.SetActive(true);
        reiniciarBoton.gameObject.SetActive(true);
        esJuegoActivo = false;
        
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}