using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablero : MonoBehaviour
{

    public GameObject casilla;

    NumPosicion nomPos;
    

    public Material Rojo;
    public Material Verde;

    Color color;
    ArrayList posicionRojoI = new ArrayList();
    ArrayList posicionRojoJ = new ArrayList();
    ArrayList posicionVerdeI = new ArrayList();
    ArrayList posicionVerdeJ = new ArrayList();





    GameObject[] clon;

    // Start is called before the first frame update
    void Start()
    {



        int contador = 1;
        for (int i = -4; i < 5; i++)
        {
            
            for (int j = -6; j < 4; j++)
            {
                
                GameObject casillaTemporal = Instantiate(casilla, new Vector3(j, i, 0), Quaternion.identity);
                 
                
                if (i % 2 == 0)
                {
                    color = Color.magenta;
                    casillaTemporal.GetComponent<casilla>().ponerColor(color);
                }
                //RedPosition
                if ((j==-5 && i == -2) || (j == -1 && i == -1) ||
                    (j == -2 && i == 1) || (j == 0 && i == 3) ||
                    (j == -5 && i == 4) || (j == 2 && i == 4))
                {
                    posicionRojoI.Add(i);
                    posicionRojoJ.Add(j);
                    color = Color.red;
                    casillaTemporal.GetComponent<casilla>().ponerColor(color);

                }
                //GreenPosition
                if ((j == 0 && i == -4) || (j == -2 && i == -3) ||
                    (j == -4 && i == -1) || (j == 2 && i == 0) ||
                    (j == -6 && i == 2))
                {
                    posicionVerdeI.Add(i);
                    posicionVerdeJ.Add(j);
                    color = Color.green;
                    casillaTemporal.GetComponent<casilla>().ponerColor(color);
                }



                    casilla.GetComponent<casilla>().numCasilla = contador;
                    contador++;
                

            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public ArrayList getPosicionRojoI()
    {
        return this.posicionRojoI;
    }

    public ArrayList getPosicionRojoJ()
    {
        return this.posicionRojoJ;
    }

    public ArrayList getPosicionVerdeI()
    {
        return this.posicionVerdeI;
    }

    public ArrayList getPosicionVerdeJ()
    {
        return this.posicionVerdeJ;
    }

}
