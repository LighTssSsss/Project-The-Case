using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetivoDialogo : MonoBehaviour
{
    public string objetivoPrincipal;
    public TextMeshProUGUI textoObjetivo;
    public bool estadoDialogo;

    // Update is called once per frame
    void Update()
    {
        CambioObjetivos();
    }

    public void CambioObjetivos()
    {
        if (estadoDialogo == true)
        {
            textoObjetivo.text = objetivoPrincipal;
        }
    }
}
