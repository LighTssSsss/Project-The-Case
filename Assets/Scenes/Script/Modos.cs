using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modos : MonoBehaviour
{
    public bool soyFantasma;
    public bool soyNormal;
    public GameObject fantasma;
    public GameObject humano;
    public bool puedoCambiar;
    public GameObject particulas;
    public Transform posicion;
    private SonidoManager sonidoManager;
    public Animator boton,botonNormal;
    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
        fantasma.SetActive(false);
        humano.SetActive(true);
        soyNormal = true;
        soyFantasma = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Player vid = GetComponent<Player>();
        if (vid.vidaJugador <= 0)
        {
            

            humano.SetActive(true);
            fantasma.SetActive(false);
            puedoCambiar = true;
        }
    }

    public void BotonFantasma()
    {
        if(puedoCambiar == false)
        {
            GameObject gameObjects = Instantiate(particulas,posicion.position,Quaternion.identity);
            Destroy(gameObjects, 3f);
           
            sonidoManager.SeleccionarAudio(5, 0.5f);
            boton.Play("BotonFantasmaNodisponible");
            botonNormal.Play("BotonNormalDisponibles");
            // botonNormal.Play("BotonNormalDisponible");
            gameObject.layer = 14;
            fantasma.SetActive(true);
            humano.SetActive(false);
            soyNormal = false;
            
            soyFantasma = true;
        }
        
    }

    public void BotonCuerpo()
    {
        if(puedoCambiar == false)
        {
            GameObject gameObjects = Instantiate(particulas, posicion.position, Quaternion.identity);
            Destroy(gameObjects, 3f);
            boton.Play("BotonFantasmaDisponible");
            botonNormal.Play("BotonNormalQuieto");
            // botonNormal.Play("BotonNormalNoDisponible");
            sonidoManager.SeleccionarAudio(5, 0.5f);
            fantasma.SetActive(false);
            gameObject.layer = 13;
            humano.SetActive(true);
            
            soyNormal = true;
            soyFantasma = false;
        }
        
    }


    public void ReproducemeAnimacion(string animacionB)
    {
        boton.Play(animacionB);
        //botonNormal.Play(animacionB);
    }



    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Casas")
        {
            if (soyFantasma == true)
            {
                print("Boton fantasma desactivado");
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Casas")
        {
            if(soyFantasma == true)
            {
                print("Boton fantasma desactivado");
            }
           
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (soyFantasma == true && collision.gameObject.tag == "Casas" || collision.gameObject.tag == "objetos" || collision.gameObject.tag == "Objeto1")
        {
            print("Boton fantasma activado");
        }
    }*/
}
