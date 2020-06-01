using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casilla : MonoBehaviour
{

    public int numCasilla;
    public Material color;

    public void ponerColor(Color color_)
    {

        GetComponent<Renderer>().material.color = color_;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
