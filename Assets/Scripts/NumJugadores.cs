using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumJugadores : MonoBehaviour
{

    bool uno;
    bool dos;
    bool tres;
    bool cuatro;
    bool cinco;
    int numero;

    public GameObject panel;
    public GameObject jugador;

    public GameObject ocultarInfo;


    public string[] nombres;
    GameObject[] jug ;
    Sprite[] miPersonaje;


    SeleccionPersonaje selected;


    // Start is called before the first frame update
    void Start()
    {
        selected = FindObjectOfType<SeleccionPersonaje>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crearJugadores(int numero)
    {
        jug = new GameObject[numero];
        
        miPersonaje = selected.enviarSpriteJugador();

        for (int i = 0; i < numero; i++)
        {
            jug[i] = Instantiate(jugador, new Vector3(-7, -4, 0), Quaternion.identity);
            jug[i].GetComponent<SpriteRenderer>().sprite = miPersonaje[i];
        }

    }

    public void insertarJugadores()
    {
        numero = 0;

        if (uno)
        {
            numero = 1;
        }
        if (dos)
        {
            numero = 2;
        }
        if (tres)
        {
            numero = 3;
        }
        if (cuatro)
        {
            numero = 4;
        }
        if (cinco)
        {
            numero = 5;
        }
        
        selected.obtnDato(numero);
        ocultarInfo.SetActive(false);

        //panel.SetActive(false);

        //crearJugadores(numero);
    }


    //Metodo listones
    public void listones()
    {
        crearJugadores(numero);
        panel.SetActive(false);
    }





    //numero marcado
    public void marcadaUno()
    {
        uno = true;
        dos = false;
        tres = false;
        cuatro = false;
        cinco = false;

    }
    public void marcadaDos()
    {
        uno = false;
        dos = true;
        tres = false;
        cuatro = false;
        cinco = false;

    }
    public void marcadaTres()
    {
        uno = false;
        dos = false;
        tres = true;
        cuatro = false;
        cinco = false;

    }
    public void marcadaCuatro()
    {
        uno = false;
        dos = false;
        tres = false;
        cuatro = true;
        cinco = false;

    }
    public void marcadaCinco()
    {
        uno = false;
        dos = false;
        tres = false;
        cuatro = false;
        cinco = true;

    }

    

    public GameObject[] getJugadores()
    {
        return this.jug;
    }

    public int getNumero()
    {
        return this.numero;
    }

}
