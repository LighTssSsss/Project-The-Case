using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modos : MonoBehaviour
{
    public bool soyFantasma;
    public bool soyNormal;
    public GameObject fantasma;
    public GameObject humano;
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
        
    }

    public void BotonFantasma()
    {
        Debug.Log("Soy Fantasma buuuuu");
        gameObject.layer = 14;
        fantasma.SetActive(true);
        humano.SetActive(false);
        soyNormal = false;
        soyFantasma = true;
    }

    public void BotonCuerpo()
    {
        fantasma.SetActive(false);
        gameObject.layer = 13;
        humano.SetActive(true);
        Debug.Log("Soy humano");
        soyNormal = true;
        soyFantasma = false;
    }

    
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
    }
}
