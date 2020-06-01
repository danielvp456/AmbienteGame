using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MantenerInfo : MonoBehaviour
{
    static MantenerInfo permanent ;
    static string nombreGanador;


    // Start is called before the first frame update
    void Start()
    {


        if (permanent != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            permanent = this;
        }
        Debug.Log("i hace: " + nombreGanador);

    }

    public void setNombreGanador(string ganador)
    {
        nombreGanador = ganador;
        Debug.Log("mi ganador!! " + nombreGanador);
    }

    public string getNombreGanador()
    {
        return nombreGanador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
