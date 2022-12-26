using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
   // [SerializeField] private GameObject dialogos;
    [SerializeField] private TextMeshProUGUI dialogo;
    [SerializeField] private TextMeshProUGUI nombre;
    public string nombresDeDialogo;
    public GameObject jugador;
    public string[] LineasDialogo;
    public float velocidadTexto;
    public int index;
    [SerializeField] private LayerMask fantasma;
    [SerializeField] private bool primeralinea = true;
    public GameObject botonContinuar;
    public bool hablo, cambio, cambiofinal;
    public bool AparecenHabilidades;
    //public float tiempo;
    public GameObject boton1, boton2;
    public List<GameObject> objetosCanvas;
    public bool termino;
    public Animator animacionCanva,botonNormal;
    public bool nopuedeMoverse;
    public GameObject canvaas;
    public GameObject sonido1, sonido2;

    public Animator vida, inventario, Objetivos;
    // Start is called before the first frame update

    private SonidoManager sonidoManager;

    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
        
    }

    void Start()
    {
        //dialogos.SetActive(false);
        dialogo.text = string.Empty;
        ComienzaDialogo();
        boton1.SetActive(false);
        boton2.SetActive(false);
        objetosCanvas[6].SetActive(false);
        sonido1.SetActive(false);
        sonido2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();

        ApareceDialogo();

        if (dialogo.text == LineasDialogo[index])
        {
            botonContinuar.SetActive(true);

        }

        if (dis.disponible == false)
        {
            dialogos.SetActive(false);
            termino = true;
            //StopAllCoroutines();
        }

        if(index == 15)
        {
            ObjetivoDialogo objD = GameObject.FindObjectOfType<ObjetivoDialogo>();
      
            objD.estadoDialogo = true;

        }

       
        
       else if (dis.disponible == false && index < 0) //Cuidado
        {
            index = 0;
            print("Chaoo");
        }

        /*
        else
        {
            StopAllCoroutines();
            dialogo.text = LineasDialogo[index];
        } ****** aqui/

       if(AparecenHabilidades == true)
        {
            boton1.SetActive(true);
            boton2.SetActive(true);
        }*/

    }

    public void DialogosChica()
    {
        CanvasGeneral can = canvaas.GetComponent<CanvasGeneral>();
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();

        ApareceDialogo();

        if (dialogo.text == LineasDialogo[index])
        {
            botonContinuar.SetActive(true);

        }

        if (dis.disponible == false)
        {
            can.dialogo.SetActive(false);
            //dialogos.SetActive(false);
            termino = true;
            //StopAllCoroutines();
        }

        if(index >= 5)
        {
            nombre.text = "Fantasma:";
        }

        if(index == 12)
        {
            sonido1.SetActive(true);
        }

        if(index != 12)
        {
            sonido1.SetActive(false);
        }

        if (index == 15)
        {
            ObjetivoDialogo objD = GameObject.FindObjectOfType<ObjetivoDialogo>();
            sonido2.SetActive(true);
            objD.estadoDialogo = true;

        }
        if (index > 15)
        {
            sonido2.SetActive(false);
        }



        else if (dis.disponible == false && index < 0) //Cuidado
        {
            index = 0;
            
        }

        /*
        else
        {
            StopAllCoroutines();
            dialogo.text = LineasDialogo[index];
        }*/

        if (AparecenHabilidades == true)
        {
            boton1.SetActive(true);
            boton2.SetActive(true);
        }
    }

    bool ToqueAlFantasma()
    {
        bool aparece = false;
        Vector3 newPos = Vector3.zero;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, fantasma))
        {
            aparece = true;

        }
        return aparece;
    }

    public void ComienzaDialogo()
    {
        index = 0;
        StartCoroutine(TipoLine()); //Permite aparecer el primer texto por letra
    }

    IEnumerator TipoLine()
    {
        foreach (char c in LineasDialogo[index].ToCharArray())
        {
            dialogo.text += c;
            yield return new WaitForSeconds(velocidadTexto);
        }
    }

    public void siguienteLinea()
    {
        CanvasGeneral can = canvaas.GetComponent<CanvasGeneral>();
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();
        botonContinuar.SetActive(false);
        if (index < LineasDialogo.Length - 1 )
        {
            index++;
            primeralinea = false;
            dialogo.text = string.Empty;
            StartCoroutine(TipoLine());
        }

        else
        {
            animacionCanva.Play("ObjetoPlayerAparece");
            botonNormal.Play("BotonNormalAparece");
            vida.Play("BarraAparece");
            inventario.Play("InventarioApareceCompleto");
            Objetivos.Play("ObjetivAparece");
            nopuedeMoverse = false;
            can.dialogo.SetActive(false);
            //dialogos.SetActive(false);

           /* objetosCanvas[0].SetActive(true);
            objetosCanvas[1].SetActive(true);
            objetosCanvas[2].SetActive(true);
            objetosCanvas[3].SetActive(true);*/
            dis.aparece = false;
            AparecenHabilidades = true;
            termino = true;
        }
    }


    void Test()
    {
        //if en area ontriggerstay
        {
            //if apreto boton raycast
            {
                //abrir cajita dialogo

            }

        }
    }

    public void ApareceDialogo()
    {
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();
        if (dis.disponible == true)
        {
            OnMouseDown();
            
        }
    }

    public void ReproduceAnimacionCanva(string nombCanva)
    {
        animacionCanva.Play("nombCanva");
        botonNormal.Play("nombCanva");
        vida.Play(nombCanva);
        inventario.Play(nombCanva);
        Objetivos.Play(nombCanva);
    }

    private void OnMouseDown()
    {
        CanvasGeneral can = canvaas.GetComponent<CanvasGeneral>();
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();
        Modos mod = jugador.GetComponent<Modos>();
        if (ToqueAlFantasma() && dis.disponible == true && mod.soyFantasma == false)
        {
            //sonidoManager.SeleccionarAudio(2, 0.5f);
            nombre.text = nombresDeDialogo;
            animacionCanva.Play("ObjetoPlayerDesaparece");
            vida.Play("BarraDesaparece");
            inventario.Play("InventarioDesapareceCompleto");
            Objetivos.Play("ObjetivoDesaparece");
            botonNormal.Play("BotonNormalDesaparece");
            nopuedeMoverse = true;
            hablo = true;
            termino = false;
            dis.aparece = true;
            /*
            objetosCanvas[0].SetActive(false);
            objetosCanvas[1].SetActive(false);
            objetosCanvas[2].SetActive(false);
            objetosCanvas[3].SetActive(false);*/
            objetosCanvas[4].SetActive(false);
            objetosCanvas[5].SetActive(true);
            objetosCanvas[6].SetActive(true);
            AparecenHabilidades = false;
            can.dialogo.SetActive(true);

           // dialogos.SetActive(true);          
        }
    }
}
