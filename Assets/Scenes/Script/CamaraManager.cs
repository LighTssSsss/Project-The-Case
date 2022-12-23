using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamaraManager : MonoBehaviour
{
    public CinemachineFreeLook camara1;
    public CinemachineVirtualCamera [] camaras;
    public GameObject objetoDialogo;

    private void Start()
    {
        
    }

    private void Update()
    {
        CambioCamaras();
    }

    public void CambioCamaras()
    {
        Dialogo dialog = objetoDialogo.GetComponent<Dialogo>();

        if (dialog.hablo == true)
        {
            camaras[0].Priority = 1;
            camara1.Priority = 0;
        }

        if(dialog.index == 13)
        {
            camaras[0].Priority = 0;
            camaras[1].Priority = 1;
        }

        if(dialog.index == 14)
        {
            camaras[0].Priority = 1;
            camaras[1].Priority = 0;
        }


        if(dialog.termino == true)
        {
            camaras[0].Priority = 0;
            camaras[1].Priority = 0;
            camara1.Priority = 1;
        }
    }
}
