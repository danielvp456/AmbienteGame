using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPreguntas : MonoBehaviour
{

    public GameObject panel;
    public Text label01;
    public Text label02;
    public Text label03;

    dado miDado;

    Preguntas preg;
    player jugador;
    public Text preguntasTexto;

    int random = 0;
    bool uno = false;
    bool dos = false;
    bool tres = false;
    string marcada;

    bool respuestaCorrecta = false;

    //Arrays de las preguntas
    ArrayList preguntas = new ArrayList();
    ArrayList respuestaUno = new ArrayList();
    ArrayList respuestaDos = new ArrayList();
    ArrayList respuestaTres = new ArrayList();
    ArrayList respuesta = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {

        miDado = FindObjectOfType<dado>();
        jugador = FindObjectOfType<player>();

        preg = FindObjectOfType<Preguntas>();
        preguntas = preg.getPreguntas();
        respuestaUno = preg.getRespuestaUno();
        respuestaDos = preg.getRespuestaDos();
        respuestaTres = preg.getRespuestaTres();
        respuesta = preg.getRespuesta();

        randPreguntas();
        
    }



    public void randPreguntas()
    {
        preg = FindObjectOfType<Preguntas>();
        preguntas = preg.getPreguntas();
        respuestaUno = preg.getRespuestaUno();
        respuestaDos = preg.getRespuestaDos();
        respuestaTres = preg.getRespuestaTres();
        respuesta = preg.getRespuesta();

        random = Random.Range(0, preguntas.Count);

        preguntasTexto.text = preguntas[random].ToString();
        label01.text = respuestaUno[random].ToString();
        label02.text = respuestaDos[random].ToString();
        label03.text = respuestaTres[random].ToString();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cerrarPanel()
    {
        if (uno)
        {
            marcada = label01.text;
        }
        if (dos)
        {
            marcada = label02.text;
        }
        if (tres)
        {
            marcada = label03.text;
        }

        
        if (marcada == respuesta[random].ToString())
        {
            respuestaCorrecta = true;
        }
        else
        {
            respuestaCorrecta = false;
        }
        //Aqui va el array de players 
        Debug.Log("la respuesta es: " + respuestaCorrecta);
        //colocar array player
        //jugador.evaluarRojo(respuestaCorrecta);
        //jugador.evaluarVerde(respuestaCorrecta);

        miDado.funcionEvaluacionPregunta(respuestaCorrecta);
        

    }


    public void marcadaUno()
    {
        uno = true;
        dos = false;
        tres = false;
    }

    public void marcadaDos()
    {
        dos = true;
        uno = false;
        tres = false;
    }

    public void marcadaTres()
    {
        tres = true;
        uno = false;
        dos = false;
    }

    public bool getRespuestaCorrecta()
    {
        return respuestaCorrecta;
    }


}
