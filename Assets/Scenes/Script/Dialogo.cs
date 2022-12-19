using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    [SerializeField] private GameObject dialogos;
    [SerializeField] private TextMeshProUGUI dialogo;
    public string[] LineasDialogo;
    public float velocidadTexto;
    private int index;
    [SerializeField] private LayerMask fantasma;
    [SerializeField] private bool primeralinea = true;
    public GameObject botonContinuar;

    public bool AparecenHabilidades;

    public GameObject boton1, boton2;
    // Start is called before the first frame update

    void Start()
    {
        dialogos.SetActive(false);
        dialogo.text = string.Empty;
        ComienzaDialogo();
        boton1.SetActive(false);
        boton2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();

        ApareceDialogo();

        if (dialogo.text == LineasDialogo[index])
        {
            botonContinuar.SetActive(true);

        }

        if (dis.disponible == false)
        {
            dialogos.SetActive(false);
           
            //StopAllCoroutines();
        }

        if(index == 12)
        {
            ObjetivoDialogo objD = GameObject.FindObjectOfType<ObjetivoDialogo>();
            AparecenHabilidades = true;
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
        }*/

       if(AparecenHabilidades == true)
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
            dialogos.SetActive(false);
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

    private void OnMouseDown()
    {
        AreaDisponible dis = GameObject.FindObjectOfType<AreaDisponible>();
        if (ToqueAlFantasma() && dis.disponible == true)
        {
            dialogos.SetActive(true);          
        }
    }
}
