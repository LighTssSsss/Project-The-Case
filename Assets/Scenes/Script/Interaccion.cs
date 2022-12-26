using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    [SerializeField] private LayerMask Boton1;
    [SerializeField] private LayerMask Boton2;
    [SerializeField] private LayerMask Boton3;
    [SerializeField] private LayerMask Boton4;

    [SerializeField] private bool prendio1, prendio2, prendio3, prendio4, completado;

    [SerializeField] private GameObject[] botones;
    [SerializeField] private GameObject puedo,puedo2,puedo3,puedo4;
    [SerializeField] private GameObject jugador;
    public  GameObject ApareceDiario;
    public bool puedotomarlo;
    public GameObject cajasonido;
    int[] ValorDado = { -1, -1, -1, -1 }; //Valor dado por el jugador
    int[] ValorEstablecido = { 0, 1, 2, 3}; // Valor Ganador
    int index = 0;
    public Animator caja;
    public GameObject coger;

    [SerializeField] private List<GameObject> Objeto = new List<GameObject>();

    [SerializeField] private bool presiono1, presiono2, presiono3, presiono4;
    public GameObject area1, area2;
    private SonidoManager sonidoManager;
    public CanvasGeneral canvCambio;
    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }

    private void Start()
    {
        coger.SetActive(false);
        ApareceDiario.SetActive(false);
        //cajaPuerta.SetActive(true);
        Objeto[0].SetActive(true);
        cajasonido.SetActive(false);
        area1.SetActive(true);
        area2.SetActive(false);
    }
    private void Update()
    {
        /*
         Modos estados = jugador.GetComponent<Modos>();
         PrenderObjeto prenOb = puedo.GetComponent<PrenderObjeto>();
         PrenderObjeto  prenObj = puedo2.GetComponent<PrenderObjeto>();
         PrenderObjeto prenObje = puedo3.GetComponent<PrenderObjeto>();
         PrenderObjeto prenObjet = puedo4.GetComponent<PrenderObjeto>();


        if (Input.GetMouseButtonDown(0) && ToqueBoton1() && presiono1 == false && prenOb.puedoTomarlo == true && estados.soyFantasma == false)
        {
                    
            ValorDado[index] = 0;
            ComprobacionArreglo();
            //Botones bo = GameObject.Find
            prendio1 = true;
            if(prendio1 == true && prendio2 == false ||prendio3 == true || prendio4 == true )
            {
                prendio3 = false;
                prendio4 = false;
                presiono2 = false;
                presiono3 = false;
                presiono4 = false;
            }
            print("Boton 1 se presiono");
            presiono1 = true;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton2() && presiono2 == false && prenObj.puedoTomarlo == true && estados.soyFantasma == false) 
        {
            
            ValorDado[index] = 1;
            ComprobacionArreglo();
            prendio2 = true;
            print("Boton 2 se presiono");
            presiono2 = true;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton3() && presiono3 == false && prenObje.puedoTomarlo == true && estados.soyFantasma == false)
        {
           
            ValorDado[index] = 2;
            ComprobacionArreglo();
            prendio3 = true;
            print("Boton 3 se presiono");
            presiono3 = true; //ver esto;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton4() && prenObjet.puedoTomarlo == true && estados.soyFantasma == false)
        {

            
            ValorDado[index] = 3;
            ComprobacionArreglo();
            prendio4 = true;
            print("Boton 4 se presiono");
            
        }

        AbreLaCaja();*/
        
    }
    public void PuzzleFinal()
    {
        OnMouseDown();
    }


    bool ToqueBoton1()
    {
        PrenderObjeto prenOb = puedo.GetComponent<PrenderObjeto>();
        Modos estados = jugador.GetComponent<Modos>();
        bool prendio = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //PrenderObjeto prenOb = jugador.GetComponent<PrenderObjeto>();
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton1))
        {
            prendio = true;
            if (prenOb.puedoTomarlo == true && estados.soyFantasma == false)
            {
                hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
               // Debug.Log("Luz" + hit.collider.gameObject.name);
            }
                
        }
        return prendio;
    }

    bool ToqueBoton2()
    {
        PrenderObjeto prenObj = puedo2.GetComponent<PrenderObjeto>();
        Modos estados = jugador.GetComponent<Modos>();
        bool prendio2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton2))
        {
            prendio2 = true;
            if (prenObj.puedoTomarlo == true && estados.soyFantasma == false)
            {
                hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
               // Debug.Log("Luz" + hit.collider.gameObject.name);
            }
                
        }
        return prendio2;
    }

    bool ToqueBoton3()
    {
        PrenderObjeto prenObje = puedo3.GetComponent<PrenderObjeto>();
        Modos estados = jugador.GetComponent<Modos>();
        bool prendio3 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton3))
        {
            prendio3 = true;
            if (prenObje.puedoTomarlo == true && estados.soyFantasma == false)
            {
                hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
               // Debug.Log("Luz" + hit.collider.gameObject.name);
            }
            
        }
        return prendio3;
    }

    bool ToqueBoton4()
    {
        PrenderObjeto prenObjet = puedo4.GetComponent<PrenderObjeto>();
        Modos estados = jugador.GetComponent<Modos>();
        bool prendio4 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton4))
        {
            prendio4 = true;
            if (prenObjet.puedoTomarlo == true && estados.soyFantasma == false)
            {
                hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
                //Debug.Log("Luz" + hit.collider.gameObject.name);
            }
            
        }
        return prendio4;
    }


    public void ComprobacionArreglo()
    {
        if(ValorDado[index] == ValorEstablecido[index])
        {
           

            if (index < 3)
            {
                index++;
            }
        }


        else
        {

            if(completado == false)
            {
                ApagarLuces();
                sonidoManager.SeleccionarAudio(9, 0.5f);
                ValorDado[0] = -1;
                ValorDado[1] = -1;
                ValorDado[2] = -1;
                ValorDado[3] = -1;

                prendio1 = false;
                prendio2 = false;
                prendio3 = false;
                prendio4 = false;
                presiono1 = false;
                presiono2 = false;
                presiono3 = false;
                presiono4 = false;
                index = 0;
               
            }
            //Botones ga = ga.GetComponent<Botones>().EncenderLuz(false);
            /*
            ApagarLuces();

            ValorDado[0] = -1;
            ValorDado[1] = -1;
            ValorDado[2] = -1;
            ValorDado[3] = -1;

            prendio1 = false;
            prendio2 = false;
            prendio3 = false;
            prendio4 = false;

            index = 0;
            print("No es igual");*/
           
        }
       
    }

    public void AbreLaCaja()
    {
        //botones[0] && botones[1]...
        
        if(prendio1 == true && prendio2 == true && prendio3 == true && prendio4 == true)
        {
            caja.Play("CajaFuerteAbriendose");
            cajasonido.SetActive(true);
            coger.SetActive(true);
            completado = true;
            area1.SetActive(false);
            //Objeto[0].SetActive(false);
           if(prendio1 == true && prendio2 == true && prendio3 == true && prendio4 == true && puedotomarlo == true)
            {
                ApareceDiario.SetActive(true);
                area2.SetActive(true);
            }
            
        }

        /*
        if(botones[0] && botones[1] && botones[2] && botones[3]) 
        {
            Objeto[0].SetActive(false);
        } */
    }

    public void ReproducemeAnimacion(string nombres)
    {
        caja.Play(nombres);
    }

    public void ApagarLuces()
    {
        for (int i = 0; i < botones.Length; i++)
        {

            botones[i].GetComponent<Botones>().EncenderLuz(false);
        }
    }

    private void OnMouseDown()
    {
        Modos estados = jugador.GetComponent<Modos>();
        PrenderObjeto prenOb = puedo.GetComponent<PrenderObjeto>();
        PrenderObjeto prenObj = puedo2.GetComponent<PrenderObjeto>();
        PrenderObjeto prenObje = puedo3.GetComponent<PrenderObjeto>();
        PrenderObjeto prenObjet = puedo4.GetComponent<PrenderObjeto>();


        if ( ToqueBoton1() && presiono1 == false && prenOb.puedoTomarlo == true && estados.soyFantasma == false)
        {
            sonidoManager.SeleccionarAudio(8, 0.5f);
            ValorDado[index] = 0;
            ComprobacionArreglo();
            //Botones bo = GameObject.Find
            prendio1 = true;
            if (prendio1 == true && prendio2 == false || prendio3 == true || prendio4 == true)
            {
                prendio3 = false;
                prendio4 = false;
                presiono2 = false;
                presiono3 = false;
                presiono4 = false;
            }
           
            presiono1 = true;
        }

        else if (ToqueBoton2() && presiono2 == false && prenObj.puedoTomarlo == true && estados.soyFantasma == false)
        {
            sonidoManager.SeleccionarAudio(8, 0.5f);
            ValorDado[index] = 1;
            ComprobacionArreglo();
            prendio2 = true;
           
            presiono2 = true;
        }

        else if ( ToqueBoton3() && presiono3 == false && prenObje.puedoTomarlo == true && estados.soyFantasma == false)
        {
            sonidoManager.SeleccionarAudio(8, 0.5f);
            ValorDado[index] = 2;
            ComprobacionArreglo();
            prendio3 = true;
          
            presiono3 = true; //ver esto;
        }

        else if (ToqueBoton4() && prenObjet.puedoTomarlo == true && estados.soyFantasma == false)
        {
            Objetivo obsFinal = GameObject.FindObjectOfType<Objetivo>();
            sonidoManager.SeleccionarAudio(8, 0.5f);
            obsFinal.estado6 = true;
            ValorDado[index] = 3;
            ComprobacionArreglo();
            prendio4 = true;
            puedotomarlo = true;
            //canvCambio.cambiamelo = false;

        }

        AbreLaCaja();

    }
}
