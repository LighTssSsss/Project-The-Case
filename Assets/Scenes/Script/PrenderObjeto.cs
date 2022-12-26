using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderObjeto : MonoBehaviour
{
    public bool puedoTomarlo;
    [SerializeField] private GameObject ImagenTomar;
    public GameObject playerEstado;
    public bool sonido;

    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ImagenTomar.SetActive(false);
        if(sonido == true)
        {
            sonidoManager.SeleccionarAudio(1, 0.9f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        Modos modPlayer = playerEstado.GetComponent<Modos>();

        if (other.gameObject.tag == "Player" && modPlayer.soyFantasma == false)
        {
           // Debug.Log("Prendio el objeto");
           // sonidoManager.SeleccionarAudio(1, 0.9f);
            ImagenTomar.SetActive(true);
            puedoTomarlo = true;

        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        Modos modPlayer = playerEstado.GetComponent<Modos>();

        if(other.gameObject.tag == "Player" && modPlayer.soyFantasma == false)
        {
            Debug.Log("Prendio el objeto");
            ImagenTomar.SetActive(true);
            puedoTomarlo = true;
           
        }
    }*/

    private void OnTriggerExit(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        if (other.gameObject.tag == "Player" )
        {
           // Debug.Log("Ya no prende el objeto");
            sonido = false;
            ImagenTomar.SetActive(false);
            puedoTomarlo = false;
        }
    }
}
