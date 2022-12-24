using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lugar3 : MonoBehaviour
{
    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objeto3")
        {
            sonidoManager.SeleccionarAudio(11, 0.8f);
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar3 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto3")
        {
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar3 = false;
        }
    }
}
