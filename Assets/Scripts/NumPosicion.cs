using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumPosicion : MonoBehaviour
{

    public TextMeshProUGUI nombreJugador;
    public TextMeshProUGUI posicionJugador;

    TextMeshProUGUI textMesh;
    player jugador;


    // Start is called before the first frame update
    void Start()
    {

    }


    public void colocarNombreJugador(string nombre)
    {
        nombreJugador.text = nombre;
    }

    public void ubicacionJugador(string pos)
    {

        posicionJugador.text = pos; 
    }

}
