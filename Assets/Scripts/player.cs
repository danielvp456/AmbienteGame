using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public bool win;

    int posicion = 0;

    float caminoPositivo = 1;
    float random;
    bool evaluacion = false;

    dado miDado;
    tablero miTablero;
    PanelPreguntas panelsito;

    SpriteRenderer miSprite;

    ArrayList posicionRojoI = new ArrayList();
    ArrayList posicionRojoJ = new ArrayList();
    ArrayList posicionVerdeI = new ArrayList();
    ArrayList posicionVerdeJ = new ArrayList();

    //Variables para el sprite del jugador

    // Start is called before the first frame update
    void Start()
    {


        miDado = FindObjectOfType<dado>();
        random = 0;
        miTablero = FindObjectOfType<tablero>();
        panelsito = FindObjectOfType<PanelPreguntas>();
        win = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DadoArrojado(float valor, int pos)
    {
        random = valor;
        posicion = pos;


        while (random > 0)
        {

            var newX = transform.position.x;
            var newY = transform.position.y;


            if (newX == 3 && newY == 4)
            {
                win = true;
                break;
            }

            if (newX == 3 || newX == -6)
            {
                if (newX == -6 && newY == -4)
                {
                    newX += 1 * caminoPositivo;
                    random--;
                    transform.position = new Vector3(newX, newY, -1);
                    posicion++;
                    evaluacion = true;
                }
                else
                {
                    if (evaluacion == false)
                    {
                        newY += 1;
                        random--;
                        caminoPositivo *= -1;
                        transform.position = new Vector3(newX, newY, -1);
                        posicion++;
                        evaluacion = true;
                    }
                    else
                    {
                        
                        newX += (1 * caminoPositivo);
                        random--;
                        transform.position = new Vector3(newX, newY, -1);
                        posicion++;
                        evaluacion = true;
                        

                    }

                }
            }
            else
            {
                newX += (1 * caminoPositivo);
                random--;
                transform.position = new Vector3(newX, newY, -1);
                posicion++;
                evaluacion = false;


            }

        }
        
        miDado.darPosicionEnPregunta(posicion);

        float i = transform.position.y;
        float j = transform.position.x;

        if (j == 3 && i == 4)
        {
            miDado.GanoJugador();
        }
        else
        {

            if ((i == -2 && j == -5) || (i == -1 && j == -1) || (i == 1 && j == -2) ||
                (i == 3 && j == 0) || (i == 4 && j == -5) || (i == 4 && j == 2) ||
                (j == 0 && i == -4) || (j == -2 && i == -3) || (j == -4 && i == -1) ||
                (j == 2 && i == 0) || (j == -6 && i == 2))
            {
                miDado.openPanel();
            }
            else
            {

                miDado.moverDeJugador();
            }

        }



    }

    //metodos para evaluar las posiciones rojas 
    public void evaluarRojo(bool resp)
    {

        float i = this.transform.position.y;
        float j = this.transform.position.x;

        if (resp == false)
        {
            StartCoroutine(rojo(i, j));
        }
        miDado.ClosePanel();


    }

    IEnumerator rojo(float i, float j)
    {
        miDado.imagenRoja();
        yield return new WaitForSeconds(1);

        if (i == -2 && j == -5)
        {
            transform.position = new Vector3(-5, -4, -1);
            posicion -= 20;
        }
        if (i == -1 && j == -1)
        {
            transform.position = new Vector3(-1, -3, -1);
            posicion -= 20;
        }
        if (i == 1 && j == -2)
        {
            transform.position = new Vector3(-3, -1, -1);
            posicion -= 19;
        }
        if (i == 3 && j == 0)
        {
            transform.position = new Vector3(-1, 1, -1);
            posicion -= 19;
        }
        if (i == 4 && j == -5)
        {
            transform.position = new Vector3(-5, 2, -1);
            posicion -= 20;
        }
        if (i == 4 && j == 2)
        {
            transform.position = new Vector3(2, 2, -1);
            posicion -= 20;
        }

        miDado.darPosicionEnPregunta(posicion);
        miDado.moverDeJugador();
        
    }
    /// fin metodos posicione rojas
    /// 

    //metodos para evaluar las posiciones verdes
    public void evaluarVerde(bool resp)
    {
        
        float i = this.transform.position.y;
        float j = this.transform.position.x;

        if (resp == true)
        {
            StartCoroutine(verde(i, j));
        }

        miDado.ClosePanel();


    }


    IEnumerator verde(float i, float j)
    {
        miDado.imagenVerde();
        yield return new WaitForSeconds(1);

        if (i == -4 && j == 0)
        {
            this.transform.position = new Vector3(0, -2, -1);
            posicion += 20;
        }
        if (i == -3 && j == -2)
        {
            this.transform.position = new Vector3(-5, -1, -1);
            posicion += 23;
        }
        if (i == -1 && j == -4)
        {
            this.transform.position = new Vector3(-4, 1, -1);
            posicion += 20;
        }
        if (i == 0 && j == 2)
        {
            this.transform.position = new Vector3(0, 2, -1);
            posicion += 18;
        }
        if (i == 2 && j == -6)
        {
            this.transform.position = new Vector3(-4, 4, -1);
            posicion += 22;
        }
        miDado.darPosicionEnPregunta(posicion);
        miDado.moverDeJugador();
        
    }



    public int getPosicion()
    {
        return this.posicion;
    }






    public bool getWin()
    {
        return win;
    }




}
