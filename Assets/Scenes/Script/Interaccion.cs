using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    [SerializeField] private LayerMask Boton1;
    [SerializeField] private LayerMask Boton2;
    [SerializeField] private LayerMask Boton3;
    [SerializeField] private LayerMask Boton4;

    [SerializeField] private bool prendio1, prendio2, prendio3, prendio4;

    [SerializeField] private GameObject[] botones;

    
    int[] ValorDado = { -1, -1, -1, -1 }; //Valor dado por el jugador
    int[] ValorEstablecido = { 0, 1, 2, 3}; // Valor Ganador
    int index = 0;

    [SerializeField] private List<GameObject> Objeto = new List<GameObject>();
    

    private void Start()
    {
        //cajaPuerta.SetActive(true);
        Objeto[0].SetActive(true);
       
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && ToqueBoton1())
        {
                    
            ValorDado[index] = 0;
            ComprobacionArreglo();
            //Botones bo = GameObject.Find
            prendio1 = true;
            if(prendio1 == true && prendio3 == true || prendio4 == true)
            {
                prendio3 = false;
                prendio4 = false;
            }
            print("Boton 1 se presiono");

        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton2() )
        {
            
            ValorDado[index] = 1;
            ComprobacionArreglo();
            prendio2 = true;
            print("Boton 2 se presiono");
        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton3() )
        {
           
            ValorDado[index] = 2;
            ComprobacionArreglo();
            prendio3 = true;
            print("Boton 3 se presiono");
        }

        else if (Input.GetMouseButtonDown(0) && ToqueBoton4())
        {

            
            ValorDado[index] = 3;
            ComprobacionArreglo();
            prendio4 = true;
            print("Boton 4 se presiono");
        }

        AbreLaCaja();
        
    }


    bool ToqueBoton1()
    {
        bool prendio = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton1))
        {
            prendio = true;
            hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
            Debug.Log("Luz" + hit.collider.gameObject.name);
        }
        return prendio;
    }

    bool ToqueBoton2()
    {
        bool prendio2 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton2))
        {
            prendio2 = true;
            hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
            Debug.Log("Luz" + hit.collider.gameObject.name);
        }
        return prendio2;
    }

    bool ToqueBoton3()
    {
        bool prendio3 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton3))
        {
            prendio3 = true;
            hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
            Debug.Log("Luz" + hit.collider.gameObject.name);
        }
        return prendio3;
    }

    bool ToqueBoton4()
    {
        bool prendio4 = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, Boton4))
        {
            prendio4 = true;
            hit.collider.gameObject.GetComponent<Botones>().EncenderLuz(true);
            Debug.Log("Luz" + hit.collider.gameObject.name);
        }
        return prendio4;
    }


    public void ComprobacionArreglo()
    {
        if(ValorDado[index] == ValorEstablecido[index])
        {
            print("valor igual");

            if (index < 3)
            {
                index++;
            }
        }


        else
        {


            //Botones ga = ga.GetComponent<Botones>().EncenderLuz(false);

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
            print("No es igual");
           
        }
       
    }

    public void AbreLaCaja()
    {
        //botones[0] && botones[1]...
        
        if(prendio1 == true && prendio2 == true && prendio3 == true && prendio4 == true)
        {
            Objeto[0].SetActive(false);
        }

        /*
        if(botones[0] && botones[1] && botones[2] && botones[3]) 
        {
            Objeto[0].SetActive(false);
        } */
    }

    public void ApagarLuces()
    {
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].GetComponent<Botones>().EncenderLuz(false);
        }
    }
}
