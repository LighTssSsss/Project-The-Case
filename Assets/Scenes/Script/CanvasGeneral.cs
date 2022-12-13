using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGeneral : MonoBehaviour
{
    public GameObject inventario;
    public GameObject iconoNuevoObjeto;

    public GameObject casillaUno;
    // Start is called before the first frame update
    void Start()
    {
        iconoNuevoObjeto.SetActive(false);
        inventario.SetActive(false);
        casillaUno.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnciendeAlertaNuevoObjeto();
    }

    public void EnciendeAlertaNuevoObjeto()
    {
       /* Recoleccion muestralo = GetComponent<Recoleccion>();
        if(muestralo.MuestrameNuevoObjeto() == true)
        {
            iconoNuevoObjeto.SetActive(true);
        }*/
    }

    public void BotonAbrirMenuDeInventario()
    {
        /* apaga
        iconoNuevoObjeto.SetActive(false);
        Recoleccion muestralo = GetComponent<Recoleccion>();
        inventario.SetActive(true);
        muestralo.CambiameNuevoObjeto(false);*/
    }

    public void BotonCerrarMenuDeInventario()
    {
        inventario.SetActive(false);
        casillaUno.SetActive(false);
    }

    
    public void BotonCasillaUno()
    {
        inventario.SetActive(false);
        casillaUno.SetActive(true);
    }

   
    
}
