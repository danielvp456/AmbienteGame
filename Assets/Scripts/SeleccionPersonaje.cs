using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SeleccionPersonaje : MonoBehaviour
{

    public TextMeshProUGUI textoBtn;
    public InputField textoInput;

    int contadorArrays = 0;

    Image image;
    public Sprite[] sprites;
    public Sprite[] personaje;
    Sprite[] enviarSprite;
    int contador = 0;


    //nombre jugador variables
    string[] nombres;
    string playerName;
    public GameObject inputField;
    public GameObject musica;

    int listos = 0;
    int contadorSprites = 0;

    NumJugadores numJug;
    Sprite personajeSeleccionado;


    int numeroJugadores = 0;

    //Variables posicion jugador
    int[] posJugador;

    // Start is called before the first frame update
    void Start()
    {
        
        numJug = FindObjectOfType<NumJugadores>();
        image = GetComponent<Image>();
        image.sprite = sprites[0];

        textoBtn.text = "0";

        
    }

    public void obtnDato(int numero)
    {
        numeroJugadores = numero;

        nombres = new string[numero];
        enviarSprite = new Sprite[numero];
        posJugador = new int[numero];
    }


    public void btnDerecha()
    {
        contador++;

        if (contador < sprites.Length)
        {
            image.sprite = sprites[contador];
        }
        if (contador == sprites.Length)
        {
            contador = 0;
            image.sprite = sprites[contador];
        }
    }

    public void btnIzquierda()
    {
        contador--;
        if (contador == -1)
        {
            contador = sprites.Length - 1;
            image.sprite = sprites[contador];
        }
        else
        {
            image.sprite = sprites[contador];
        }

    }

    public void listones()
    {
        playerName = inputField.GetComponent<Text>().text;

        //AQUI

       

        if (numeroJugadores > 1)
        {
            
            enviarSprite[contadorSprites] = personaje[contador];
            nombres[contadorArrays] = playerName;
            numeroJugadores--;
            contadorSprites++;
            contadorArrays++;
            textoInput.text.Remove(0);
            textoInput.text = "";

        }
        else
        {
            enviarSprite[contadorSprites] = personaje[contador];
            nombres[contadorArrays] = playerName;
            contadorArrays++;
            numJug.listones();
            textoInput.text = "";
        }

        
        if (numeroJugadores ==  1)
        {
            textoBtn.text = "Listo!!";
        }
        else
        {
            textoBtn.text = contadorArrays.ToString();
        }


        musica.SetActive(true);

    }


    public Sprite[] enviarSpriteJugador()
    {
        return this.enviarSprite;
    }

    public string[] getNombres()
    {
        return this.nombres;
    }

    public int[] getPosicionJugador()
    {
        return this.posJugador;
    }
    

}
