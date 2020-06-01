using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dado : MonoBehaviour
{

    public Image image;

    int[] posicionJugador;

    SpriteRenderer mySprite;
    Animator animDado;

    SeleccionPersonaje seleccionPersonaje;
    NumJugadores numJugadores;
    NumPosicion nomPos;
    string[] nombreJugadores;
    GameObject[] misJugadores;


    [SerializeField] Sprite[] dados;

    int contador = 0;
    public int tiempoAnim = 20;


    [SerializeField] GameObject panel;
    public GameObject panelPreguntas;

    MantenerInfo mantenerInfo;



    player jugador;
    int valor = 0;

    int turno;

    int random;


    // Start is called before the first frame update
    void Start()
    {
        image.color = Color.magenta;
        nomPos = FindObjectOfType<NumPosicion>();
        numJugadores = FindObjectOfType<NumJugadores>();
        mySprite = GetComponent<SpriteRenderer>();
        animDado = GetComponent<Animator>();
        seleccionPersonaje = FindObjectOfType<SeleccionPersonaje>();
        mantenerInfo = FindObjectOfType<MantenerInfo>();

        turno = 0;

        //jugador = FindObjectOfType<player>();
        random = 0;


    }
    

    public void OnMouseDown()
    {
        StartCoroutine(RandNumber());

    }

    public int getRandom()
    {
        return this.random + 1;
    }



   IEnumerator RandNumber()
    {
        misJugadores = new GameObject[numJugadores.getNumero()];
        nombreJugadores = new string[numJugadores.getNumero()];
        posicionJugador = new int[numJugadores.getNumero()];

        nombreJugadores = seleccionPersonaje.getNombres();
        posicionJugador = seleccionPersonaje.getPosicionJugador();

        nomPos.colocarNombreJugador(nombreJugadores[turno]);
        misJugadores = numJugadores.getJugadores();



        animDado.SetBool("dadoAnimacion", true);

        yield return new WaitForSeconds(3);
        animDado.SetBool("dadoAnimacion", false);
        random = Random.Range(0, 6);

        float numero = (float)random+1;

        switch (numero)
        {
            case 1:
                animDado.SetBool("dado01", true);
                animDado.SetBool("dado02", false);
                animDado.SetBool("dado03", false);
                animDado.SetBool("dado04", false);
                animDado.SetBool("dado05", false);
                animDado.SetBool("dado06", false);
                break;
            case 2:
                animDado.SetBool("dado02", true);
                animDado.SetBool("dado01", false);
                animDado.SetBool("dado03", false);
                animDado.SetBool("dado04", false);
                animDado.SetBool("dado05", false);
                animDado.SetBool("dado06", false);
                break;
            case 3:
                animDado.SetBool("dado03", true);
                animDado.SetBool("dado02", false);
                animDado.SetBool("dado01", false);
                animDado.SetBool("dado04", false);
                animDado.SetBool("dado05", false);
                animDado.SetBool("dado06", false);
                break;
            case 4:
                animDado.SetBool("dado04", true);
                animDado.SetBool("dado02", false);
                animDado.SetBool("dado03", false);
                animDado.SetBool("dado01", false);
                animDado.SetBool("dado05", false);
                animDado.SetBool("dado06", false);
                break;
            case 5:
                animDado.SetBool("dado05", true);
                animDado.SetBool("dado02", false);
                animDado.SetBool("dado03", false);
                animDado.SetBool("dado04", false);
                animDado.SetBool("dado01", false);
                animDado.SetBool("dado06", false);
                break;
            case 6:
                animDado.SetBool("dado06", true);
                animDado.SetBool("dado02", false);
                animDado.SetBool("dado03", false);
                animDado.SetBool("dado04", false);
                animDado.SetBool("dado05", false);
                animDado.SetBool("dado01", false);
                break;

        }


        StartCoroutine(dadoArrojado(numero));

    }


    IEnumerator dadoArrojado(float numero)
    {

        yield return new WaitForSeconds(1);
        //jugador.DadoArrojado(numero);
        misJugadores[turno].GetComponent<player>().DadoArrojado(numero, posicionJugador[turno]);

        posicionJugador[turno] = misJugadores[turno].GetComponent<player>().getPosicion();
        nomPos.ubicacionJugador(posicionJugador[turno].ToString());

        

    }

    public void funcionEvaluacionPregunta(bool respuestaCorrecta)
    {

        misJugadores[turno].GetComponent<player>().evaluarRojo(respuestaCorrecta);
        misJugadores[turno].GetComponent<player>().evaluarVerde(respuestaCorrecta);
    }

    public void darPosicionEnPregunta(int nums)
    {
        posicionJugador[turno] = nums;
        Debug.Log("entro en dado coon: " + posicionJugador[turno]);
        nomPos.ubicacionJugador(posicionJugador[turno].ToString());
    }

    public void moverDeJugador()
    {
        
        turno++;
        if (turno == nombreJugadores.Length)
        {
            turno = 0;
        }

        nomPos.colocarNombreJugador(nombreJugadores[turno]);

        panelPreguntas.GetComponent<PanelPreguntas>().randPreguntas();

    }

    public void GanoJugador()
    {
        mantenerInfo.setNombreGanador(nombreJugadores[turno]);
        SceneManager.LoadScene("GameOver");
    }


    public void openPanel()
    {
            panel.SetActive(true);
        
    }

    public void ClosePanel()
    {
        
        panel.SetActive(false);
    }



    public int getTurno()
    {
        return this.turno;
    }


    public void imagenRoja()
    {
        image.color = Color.red;
    }

    public void imagenVerde()
    {
        image.color = Color.green;
    }
    

}
