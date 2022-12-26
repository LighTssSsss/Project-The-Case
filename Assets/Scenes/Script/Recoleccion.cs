using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : MonoBehaviour
{
    [SerializeField] private LayerMask objeto1;
    [SerializeField] private LayerMask objeto2;
    [SerializeField] private LayerMask objeto3;
    [SerializeField] private LayerMask objeto4;
    [SerializeField] private LayerMask objeto5;
    [SerializeField] private bool nuevoObjeto = false;
    [SerializeField] private List<GameObject> cantidad = new List<GameObject>();
    public Interaccion tomalo;
    public bool comienzaPuzzle;

    public bool puedo,puedo2,puedo3,puedo4;
    

   

    public bool primer, segundo, tercero,cuarto,quinto;
    public bool nuevo1, nuevo2, nuevo3, nuevo4, nuevo5;
    public bool alerta;

    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TomarObjetos();
    }

    public void TomarObjetos()
    {
        OnMouseDown();
        /*
        Modos estados = GetComponent<Modos>();
        

        if (Input.GetMouseButtonDown(0) && ToqueObjeto1() && estados.soyNormal == true && puedo == true)
        {
            cantidad[0].SetActive(false);
            primer = true;
            nuevoObjeto = true;
            nuevo1 = true;
            alerta = true;
            
        }

        else if (Input.GetMouseButtonDown(0) && ToqueObjeto2() && estados.soyNormal == true && puedo2 == true)
        {
            cantidad[1].SetActive(false);
            segundo = true;
            nuevo2 = true;
            alerta = true;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueObjeto3() && estados.soyNormal == true )
        {
            cantidad[2].SetActive(false);
            tercero = true;
            nuevo3 = true;
            alerta = true;
            comienzaPuzzle = true;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueObjeto4() && estados.soyNormal == true )
        {
            cantidad[3].SetActive(false);
            cuarto = true;
            nuevo4 = true;
            alerta = true;
        }

        else if (Input.GetMouseButtonDown(0) && ToqueObjeto5() && estados.soyNormal == true)
        {
            cantidad[4].SetActive(false);
            quinto = true;
            nuevo5 = true;
            alerta = true;
        }*/


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

    bool ToqueObjeto3()
    {
        bool aparece2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, objeto3))
        {
            aparece2 = true;

        }
        return aparece2;
    }

    bool ToqueObjeto4()
    {
        bool aparece2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, objeto4))
        {
            aparece2 = true;

        }
        return aparece2;
    }

    bool ToqueObjeto5()
    {
        bool aparece2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, objeto5))
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Area")
        {
            puedo = true;
        }

        if (other.gameObject.tag == "Area2")
        {
            puedo2 = true;
        }

        if (other.gameObject.tag == "Area3")
        {
            puedo3 = true;
        }

        if (other.gameObject.tag == "Area4")
        {
            puedo4 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            puedo = false;
        }

        if (other.gameObject.tag == "Area2")
        {
            puedo2 = false;
        }

        if (other.gameObject.tag == "Area3")
        {
            puedo3 = false;
        }

        if (other.gameObject.tag == "Area4")
        {
            puedo4 = false;
        }
    }

    private void OnMouseDown()
    {
        Modos estados = GetComponent<Modos>();


        if (ToqueObjeto1() && estados.soyNormal == true && puedo == true)
        {
            sonidoManager.SeleccionarAudio(0, 0.5f);
            cantidad[0].SetActive(false);
            primer = true;
            nuevoObjeto = true;
            nuevo1 = true;
            alerta = true;

        }

        else if (ToqueObjeto2() && estados.soyNormal == true && puedo2 == true)
        {
            sonidoManager.SeleccionarAudio(0, 0.5f);
            cantidad[1].SetActive(false);
            segundo = true;
            nuevo2 = true;
            alerta = true;
        }

        else if (ToqueObjeto3() && estados.soyNormal == true)
        {
            sonidoManager.SeleccionarAudio(0, 0.5f);
            cantidad[2].SetActive(false);
            tercero = true;
            nuevo3 = true;
            alerta = true;
            comienzaPuzzle = true;
        }

        else if (ToqueObjeto4() && estados.soyNormal == true)
        {
            sonidoManager.SeleccionarAudio(0, 0.5f);
            cantidad[3].SetActive(false);
            cuarto = true;
            nuevo4 = true;
            alerta = true;
        }

        else if (ToqueObjeto5() && estados.soyNormal == true)
        {
            sonidoManager.SeleccionarAudio(0, 0.5f);
            print("toco");
            tomalo.puedotomarlo = false;
            cantidad[4].SetActive(false);
            quinto = true;
            nuevo5 = true;
            alerta = true;
        }
    }

}
