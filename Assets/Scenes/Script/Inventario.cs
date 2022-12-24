using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{

    [SerializeField] private List<GameObject> objetoInventario = new List<GameObject>();
     public List<GameObject> nuevoObjetoAparecio = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        objetoInventario[0].SetActive(false);
        objetoInventario[1].SetActive(false);
        objetoInventario[2].SetActive(false);
        objetoInventario[3].SetActive(false);
        //objetoInventario[4].SetActive(false);

        nuevoObjetoAparecio[0].SetActive(false);
        nuevoObjetoAparecio[1].SetActive(false);
        nuevoObjetoAparecio[2].SetActive(false);
        nuevoObjetoAparecio[3].SetActive(false);
        nuevoObjetoAparecio[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoInventario();
        NuevaAlerta();
    }


    public void ObjetoInventario()
    {
        Recoleccion reco = GameObject.FindObjectOfType<Recoleccion>();

        if(reco.primer == true)
        {
            objetoInventario[0].SetActive(true);
            nuevoObjetoAparecio[0].SetActive(true);
        }

       if (reco.segundo == true)
        {
            objetoInventario[1].SetActive(true);
            nuevoObjetoAparecio[1].SetActive(true);
        }

        if (reco.tercero == true)
        {
            objetoInventario[2].SetActive(true);
            nuevoObjetoAparecio[2].SetActive(true);
        }

        if (reco.cuarto == true)
        {
            objetoInventario[3].SetActive(true);
            nuevoObjetoAparecio[3].SetActive(true);
        }

        if (reco.quinto == true)
        {
            objetoInventario[4].SetActive(true);
            nuevoObjetoAparecio[4].SetActive(true);
        }
    }

    public void NuevaAlerta()
    {
        Recoleccion reco = GameObject.FindObjectOfType<Recoleccion>();

        if (reco.nuevo1 == true)
        {
            
            nuevoObjetoAparecio[0].SetActive(true);
        }

        else
        {
            nuevoObjetoAparecio[0].SetActive(false);
        }

        if (reco.nuevo2 == true)
        {
           
            nuevoObjetoAparecio[1].SetActive(true);
        }

        else
        {
            nuevoObjetoAparecio[1].SetActive(false);
        }

        if (reco.nuevo3 == true)
        {
           
            nuevoObjetoAparecio[2].SetActive(true);
        }

        else
        {
            nuevoObjetoAparecio[2].SetActive(false);
        }

        if (reco.nuevo4 == true)
        {
           
            nuevoObjetoAparecio[3].SetActive(true);
        }

        else
        {
            nuevoObjetoAparecio[3].SetActive(false);
        }

        if (reco.nuevo5 == true)
        {
           
            nuevoObjetoAparecio[4].SetActive(true);
        }

        else
        {
            nuevoObjetoAparecio[4].SetActive(false);
        }
    }
}
