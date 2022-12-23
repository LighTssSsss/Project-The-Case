using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasGeneral : MonoBehaviour
{
    public GameObject inventario;
    public GameObject iconoNuevoObjeto;
    public GameObject alertar;
    public GameManager estadoJugador;
    //public GameObject casillaUno;
    public GameObject pantallaMuerte;

    public List<GameObject> casillas = new List<GameObject>();
    public GameObject objetivoDialogos;
    public List<GameObject> bloqueos = new List<GameObject>();


    public Animator Fade;
    //public Animator pantallaMuerte;

    // Start is called before the first frame update
    void Start()
    {
        iconoNuevoObjeto.SetActive(false);
        inventario.SetActive(false);
        pantallaMuerte.SetActive(false);
        // casillaUno.SetActive(false);

        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);

        bloqueos[0].SetActive(true);
        bloqueos[1].SetActive(true);
        bloqueos[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        EnciendeAlertaNuevoObjeto();

        if(estadoJugador.muerto == true)
        {
            pantallaMuerte.SetActive(true);
        }
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
        if (estadoJugador.muerto == false)
        {
            Recoleccion alert = alertar.GetComponent<Recoleccion>();
            /* apaga
            iconoNuevoObjeto.SetActive(false);
            Recoleccion muestralo = GetComponent<Recoleccion>();

            muestralo.CambiameNuevoObjeto(false);*/

            inventario.SetActive(true);

            alert.alerta = false;
        }

        /*
        Recoleccion alert = alertar.GetComponent<Recoleccion>();
        /* apaga
        iconoNuevoObjeto.SetActive(false);
        Recoleccion muestralo = GetComponent<Recoleccion>();
        
        muestralo.CambiameNuevoObjeto(false);***************Aqui

        inventario.SetActive(true);

        alert.alerta = false;*/
    }

    public void CerrarInventario()
    {
        inventario.SetActive(false);
    }

    
    public void BotonCasillaUno()
    {
        ObjetivoDialogo objs = objetivoDialogos.GetComponent<ObjetivoDialogo>();
        if (estadoJugador.muerto == false)
        {
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo1 = false;
            casillas[0].SetActive(true);
            objs.estadoDialogo = false;
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado1 = true;
            bloqueos[0].SetActive(false);
        }
        /*
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo1 = false;
        casillas[0].SetActive(true);
        objs.estadoDialogo = false;
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado1 = true;
        bloqueos[0].SetActive(false);*/
    }

    public void BotonCasillaDos()
    {
        if (estadoJugador.muerto == false)
        {
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo2 = false;
            casillas[1].SetActive(true);
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado2 = true;
            bloqueos[1].SetActive(false);
        }
        /*
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        inventario.SetActive(false);
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo2 = false;
        casillas[1].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado2 = true;
        bloqueos[1].SetActive(false);*/
    }

    public void BotonCasillaTres()
    {
        if (estadoJugador.muerto == false)
        {
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo3 = false;
            casillas[2].SetActive(true);
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado3 = true;
        }

        /*
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        inventario.SetActive(false);
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo3 = false;
        casillas[2].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado3 = true;*/
    }

    public void BotonCasillaCuatro()
    {
        if (estadoJugador.muerto == false)
        {
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo4 = false;
            casillas[3].SetActive(true);
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado4 = true;
            bloqueos[2].SetActive(false);
        }

        /*
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        inventario.SetActive(false);
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo4 = false;
        casillas[3].SetActive(true);
        Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
        obj.estado4 = true;
        bloqueos[2].SetActive(false);*/
    }

    public void BotonCasillaCinco()
    {
        if (estadoJugador.muerto == false)
        {
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo5 = false;
            casillas[4].SetActive(true);
        }

        /*
        Recoleccion nueva = alertar.GetComponent<Recoleccion>();
        inventario.SetActive(false);
        //inventario.SetActive(false);
        //casillaUno.SetActive(true);
        nueva.nuevo5 = false;
        casillas[4].SetActive(true);*/
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

    public void CerrarTodo()
    {
        inventario.SetActive(false);
        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);
    }

    public void ReproduceLasAnimaciones(string nombresAnimaciones)
    {
        Fade.Play("nombresAnimaciones");
        //pantallaMuerte.Play("nombresAnimaciones");
    }


    public void BotonReiniciar()
    {
        Fade.Play("FadeOutNivel");
        Invoke("RecargaEscena", 1f);
    }

    public void BotonVolverAlMenu()
    {
        Fade.Play("FadeOutNivel");
        Invoke("VuelveAlMenu", 1f);
    }

    public void RecargaEscena()
    {
        SceneManager.LoadScene(1);
    }
    public void VuelveAlMenu()
    {
        SceneManager.LoadScene(0);
    }

}
