using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptButtonMenu : MonoBehaviour
{

    public GameObject scrollView;

    public void jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void salirDeLaApp()
    {
        Application.Quit();
    }


    public void articulo(bool activo)
    {
        scrollView.SetActive(activo);

    }


    public void reglas()
    {
        SceneManager.LoadScene("Reglas");
    }
}
