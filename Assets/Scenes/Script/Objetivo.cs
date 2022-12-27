using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetivo : MonoBehaviour
{
    
    public List<string> objetivo = new List<string>();
    public TextMeshProUGUI textoObjetivo;
    public bool estado1, estado2, estado3, estado4, estado5, estado6, estado7;
    //public bool entroAzul,EntroRoja,ntroNaranja,ntroalaVerde,loCompleto;
    // Update is called once per frame
    void Update()
    {
        CambioObjetivos();
    }

    public void CambioObjetivos()
    {
       
        if (estado1 == true)
        {
            textoObjetivo.text = objetivo[0];

        }



        if (estado2 == true)
        {
            textoObjetivo.text = objetivo[1];
        }

        if (estado3 == true)
        {
            textoObjetivo.text = objetivo[2];
        }

        if (estado4 == true)
        {
            textoObjetivo.text = objetivo[3];
        }

        if (estado5 == true)
        {
            textoObjetivo.text = objetivo[4];
        }
        /*
        if (estado6 == true)
        {
            textoObjetivo.text = objetivo[5];
        }

        if (estado7 == true)
        {
            textoObjetivo.text = objetivo[6];
        }*/

    }
}
