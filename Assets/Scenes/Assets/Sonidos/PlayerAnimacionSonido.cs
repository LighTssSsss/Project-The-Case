using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimacionSonido : MonoBehaviour
{
    private SonidoManager sonidoManager;
    public GameObject player;
    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }

    private void Pasos()
    {
        Modos jugg = player.GetComponent<Modos>();
        if(jugg.soyFantasma == false)
        {
            sonidoManager.SeleccionarAudio(10, 0.5f);
        }
        
    }

    private void Correr()
    {
        Modos jugg = player.GetComponent<Modos>();
        if (jugg.soyFantasma == false)
        {
            sonidoManager.SeleccionarAudio(10, 0.7f);
        }
        
    }

    private void Grito()
    {
        sonidoManager.SeleccionarAudio(7, 0.5f);
    }
}
