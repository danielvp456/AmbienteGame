using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObtnTexto : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    player jugador;


    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        jugador = FindObjectOfType<player>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

       textMesh.text = jugador.getPosicion().ToString();
        
    }
}
