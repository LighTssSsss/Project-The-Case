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
    public GameObject dialogo;
    public List<GameObject> casillas = new List<GameObject>();
    public GameObject objetivoDialogos;
    public List<GameObject> bloqueos = new List<GameObject>();
    public GameObject imagenNegraCasilla;
    private SonidoManager sonidoManager;
    public Animator Fade;
    public GameObject unoArea, dosArea, tresArea, cuatroArea;

    public GameObject objetivocambiante, objetivoArea;
   // public Objetivo1 cambiar;
    public bool cambiamelo;

    public List<GameObject> areasObjetivo = new List<GameObject>();
    //public Animator pantallaMuerte;
    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        iconoNuevoObjeto.SetActive(false);
        inventario.SetActive(false);
        pantallaMuerte.SetActive(false);
        // casillaUno.SetActive(false);
        dialogo.SetActive(false);
        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);

        bloqueos[0].SetActive(true);
        bloqueos[1].SetActive(true);
        bloqueos[2].SetActive(true);
        imagenNegraCasilla.SetActive(false);

      

    }

    // Update is called once per frame
    void Update()
    {
        EnciendeAlertaNuevoObjeto();

        if(estadoJugador.muerto == true)
        {
            pantallaMuerte.SetActive(true);
        }

        if (cambiamelo == false)
        {
            objetivocambiante.SetActive(true);
            objetivoArea.SetActive(false);
        }

        else
        {
            objetivocambiante.SetActive(false);
            objetivoArea.SetActive(true);
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
            sonidoManager.SeleccionarAudio(3, 0.5f);
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
        sonidoManager.SeleccionarAudio(1, 0.5f);
        inventario.SetActive(false);
    }

    
    public void BotonCasillaUno()
    {
        ObjetivoDialogo objs = objetivoDialogos.GetComponent<ObjetivoDialogo>();
       // Objetivo1 objAr = GameObject.FindObjectOfType<Objetivo1>();
       // ObjetivoArea objetivoA = unoArea.GetComponent<ObjetivoArea>();
        if (estadoJugador.muerto == false)
        {
            //objetivoA.area.SetActive(false);
            cambiamelo = false;
            sonidoManager.SeleccionarAudio(4, 0.5f);
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo1 = false;
            casillas[0].SetActive(true);
            imagenNegraCasilla.SetActive(true);
            objs.estadoDialogo = false;
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado1 = true;
            bloqueos[0].SetActive(false);
            areasObjetivo[0].SetActive(false);
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
        //ObjetivoArea objetivoA2 = unoArea.GetComponent<ObjetivoArea>();
        if (estadoJugador.muerto == false)
        {
            cambiamelo = false;
            //objetivoA2.area.SetActive(false);
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            sonidoManager.SeleccionarAudio(4, 0.5f);
            imagenNegraCasilla.SetActive(true);
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo2 = false;
            casillas[1].SetActive(true);
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado2 = true;
            bloqueos[1].SetActive(false);
            areasObjetivo[1].SetActive(false);
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
            cambiamelo = false;
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            sonidoManager.SeleccionarAudio(4, 0.5f);
            imagenNegraCasilla.SetActive(true);
            inventario.SetActive(false);
            //inventario.SetActive(false);
            //casillaUno.SetActive(true);
            nueva.nuevo3 = false;
            casillas[2].SetActive(true);
            Objetivo obj = GameObject.FindObjectOfType<Objetivo>();
            obj.estado3 = true;
            areasObjetivo[2].SetActive(false);
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
            cambiamelo = false;
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            sonidoManager.SeleccionarAudio(4, 0.5f);
            imagenNegraCasilla.SetActive(true);
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
            Fade.Play("FadeOutNivel");
            Recoleccion nueva = alertar.GetComponent<Recoleccion>();
            Invoke("CambioFinal", 1f);
            sonidoManager.SeleccionarAudio(4, 0.5f);
            //imagenNegraCasilla.SetActive(true);
            //inventario.SetActive(false);
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

    public void CambioFinal()
    {
        SceneManager.LoadScene(3);
    }

    public void BotonCerrarMenuDeInventarioObjetos()
    {
        //inventario.SetActive(false);
        //casillaUno.SetActive(false);
        sonidoManager.SeleccionarAudio(1, 0.5f);
        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);
        imagenNegraCasilla.SetActive(false);
    }

    public void CerrarTodo()
    {
        inventario.SetActive(false);
        casillas[0].SetActive(false);
        casillas[1].SetActive(false);
        casillas[2].SetActive(false);
        casillas[3].SetActive(false);
        casillas[4].SetActive(false);
        imagenNegraCasilla.SetActive(false);
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
        SceneManager.LoadScene(2);
    }
    public void VuelveAlMenu()
    {
        SceneManager.LoadScene(0);
    }

}
