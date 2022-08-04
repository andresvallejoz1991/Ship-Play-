using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class confDificultad : MonoBehaviour
{
    private Button boton;
    private AdminApawn gameManagerX;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("AdministradorSpawn").GetComponent<AdminApawn>();
        boton = GetComponent<Button>();
        boton.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        float intervalo = 0; 

        if(boton.gameObject.name == "btnFacil"){
            intervalo = 1f;
        }else if(boton.gameObject.name == "btnMedio")
        {
            intervalo = 2f;
        }else if(boton.gameObject.name == "btnDificil")
        {
            intervalo = 3f;
        }
        Debug.Log(boton.gameObject.name + " fue seleccionado");
        gameManagerX.ComenzarJuego(intervalo);
    }

}
