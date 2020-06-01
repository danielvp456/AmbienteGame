using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptFinal : MonoBehaviour
{
    public TextMeshProUGUI nombreGanador;
    MantenerInfo mantenerInfo;



    // Start is called before the first frame update
    void Start()
    {
        mantenerInfo = FindObjectOfType<MantenerInfo>();
        nombreGanador.text = mantenerInfo.getNombreGanador();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void BtnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
