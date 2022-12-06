using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGeneral : MonoBehaviour
{
    public GameObject inventario;

    public GameObject casillaUno;
    // Start is called before the first frame update
    void Start()
    {
        inventario.SetActive(false);
        casillaUno.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BotonAbrirMenuDeInventario()
    {
        inventario.SetActive(true);
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
