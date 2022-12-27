using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lugar1 : MonoBehaviour
{

    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Objeto1")
        {
            sonidoManager.SeleccionarAudio(11, 1f);
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Objeto1")
        {
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar1 = false;
        }
    }
}
