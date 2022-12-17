using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : MonoBehaviour
{
    [SerializeField] private LayerMask objeto1;
    [SerializeField] private LayerMask objeto2;
    [SerializeField] private LayerMask objeto3;
    [SerializeField] private bool nuevoObjeto = false;
    [SerializeField] private List<GameObject> cantidad = new List<GameObject>();

    

    [SerializeField] private List<GameObject> objetoInventario = new List<GameObject>();

    [SerializeField] private bool primer, segundo, tercero;

    public bool alerta;
    // Start is called before the first frame update
    void Start()
    {
        objetoInventario[0].SetActive(false);
        objetoInventario[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Objetos();
    }

    public void Objetos()
    {
        Modos estados = GetComponent<Modos>();
        if (Input.GetMouseButtonDown(0) && ToqueObjeto1() && estados.soyNormal == true)
        {
            cantidad[0].SetActive(false);
            primer = true;
            nuevoObjeto = true;
            objetoInventario[0].SetActive(true);
            alerta = true;
            
        }

        else if (Input.GetMouseButtonDown(0) && ToqueObjeto2() && estados.soyNormal == true)
        {
            cantidad[1].SetActive(false);
            segundo = true;
            objetoInventario[1].SetActive(true);
            alerta = true;
        }
    }

    bool ToqueObjeto1()
    {
        bool aparece = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, objeto1))
        {
            aparece = true;

        }
        return aparece;
    }

    bool ToqueObjeto2()
    {
        bool aparece2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, objeto2))
        {
            aparece2 = true;

        }
        return aparece2;
    }



    public bool MuestrameNuevoObjeto()
    {
        return this.nuevoObjeto;
    }

    public void CambiameNuevoObjeto(bool cambiamelo)
    {
        this.nuevoObjeto = cambiamelo;
    }
}
