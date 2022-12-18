using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGeneral : MonoBehaviour
{
    public GameObject inventario;
    public GameObject iconoNuevoObjeto;
    public GameObject alertar;
    //public GameObject casillaUno;

    public List<GameObject> casillas = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        iconoNuevoObjeto.SetActive(false);
        inventario.SetActive(false);
        // casillaUno.SetActive(false);

        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnciendeAlertaNuevoObjeto();
    }

    public void EnciendeAlertaNuevoObjeto()
    {
        Recoleccion alert = alertar.GetComponent<Recoleccion>();

        if(alert.alerta == true)
        {
            iconoNuevoObjeto.SetActive(true);
        }

        else
        {
            iconoNuevoObjeto.SetActive(false);
        }
    }

    public void BotonAbrirMenuDeInventario()
    {
        Recoleccion alert = alertar.GetComponent<Recoleccion>();
        /* apaga
        iconoNuevoObjeto.SetActive(false);
        Recoleccion muestralo = GetComponent<Recoleccion>();
        
        muestralo.CambiameNuevoObjeto(false);*/

        inventario.SetActive(true);

        alert.alerta = false;
    }

    public void CerrarInventario()
    {
        inventario.SetActive(false);
    }

    
    public void BotonCasillaUno()
    {
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo1 = false;
        casillas[0].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado1 = true;
    }

    public void BotonCasillaDos()
    {
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo2 = false;
        casillas[1].SetActive(true);

        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado2 = true;
    }

    public void BotonCasillaTres()
    {
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo3 = false;
        casillas[2].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado3 = true;
    }

    public void BotonCasillaCuatro()
    {
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo4 = false;
        casillas[3].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado4 = true;
    }

    public void BotonCasillaCinco()
    {
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo5 = false;
        casillas[4].SetActive(true);
    }



    public void BotonCerrarMenuDeInventarioObjetos()
    {
        //inventario.SetActive(false);
        //casillaUno.SetActive(false);
        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);
    }



}
