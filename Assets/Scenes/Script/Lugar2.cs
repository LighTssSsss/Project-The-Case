using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lugar2 : MonoBehaviour
{
    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objeto2")
        {
            sonidoManager.SeleccionarAudio(11, 0.9f);
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto2")
        {
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar2 = false;
        }
    }
}
