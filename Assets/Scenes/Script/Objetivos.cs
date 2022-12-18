using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetivos : MonoBehaviour
{
    public string objetivo;
    public TextMeshProUGUI textoObjetivo;
    public bool estado1, estado2, estado3,estado4,estado5,estado6,estado7;
    public GameObject area;


    private void Update()
    {
        CambioObjetivos();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            textoObjetivo.text = objetivo;
            area.SetActive(false);
        }
    }

    public void CambioObjetivos()
    {
        if(estado1 == true)
        {
            textoObjetivo.text = objetivo;
        }

        else if (estado2 == true)
        {
            textoObjetivo.text = objetivo;
        }

       else  if (estado3 == true)
        {
            textoObjetivo.text = objetivo;
        }

       else if (estado4 == true)
        {
            textoObjetivo.text = objetivo;
        }

        else if (estado5 == true)
        {
            textoObjetivo.text = objetivo;
        }

        else if (estado6 == true)
        {
            textoObjetivo.text = objetivo;
        }

        else if (estado7 == true)
        {
            textoObjetivo.text = objetivo;
        }

    }
}
