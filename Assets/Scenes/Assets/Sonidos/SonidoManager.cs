using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;
    private AudioSource controlAudio;

    private void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }
    
    public void SeleccionarAudio(int indice, float volumen)
    {
        controlAudio.PlayOneShot(audios[indice], volumen);
    }

   
   
}
