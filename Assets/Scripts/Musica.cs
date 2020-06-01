using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    public AudioClip[] miMusica;
    private AudioSource cancion;


    // Start is called before the first frame update
    void Start()
    {
        cancion = GetComponent<AudioSource>();
        cancion.clip = miMusica[musicaAleatoria()];
        cancion.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (!cancion.isPlaying)
        {
            cancion.clip = miMusica[musicaAleatoria()];
            cancion.Play();
        }

    }


    public int musicaAleatoria()
    {
        int random = 0;
        random = Random.Range(0, 7);
        return random;
    }

}
