using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetivo1 : MonoBehaviour
{
    public string objetivo;
    public TextMeshProUGUI textoObjetivoCollider;
    public CanvasGeneral canvCambio;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            textoObjetivoCollider.text = objetivo;
            canvCambio.cambiamelo = true;
        }
    }
}
