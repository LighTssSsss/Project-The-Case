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
    // Start is called before the first frame update

    void Start()
    {
        dialogos.SetActive(false);
        dialogo.text = string.Empty;
        //ComienzaDialogo();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && ToqueAlFantasma())
        {
            dialogos.SetActive(true);


            if (dialogo.text == LineasDialogo[index])
            {
                siguienteLinea();
                
            }
            else
            {
                StopAllCoroutines();
                dialogo.text = LineasDialogo[index];
            }

            if(index == 5)
            {
                dialogos.SetActive(true);
            }
            
            /*
            if (dialogos.activeInHierarchy && primeralinea == true)
            {
                StartCoroutine(TipoLine());


            }

            else if (dialogo.text == LineasDialogo[index])
            {
                siguienteLinea();

            }
            else
            {
                StopAllCoroutines();
                dialogo.text = LineasDialogo[index];
            }
            */
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

    void siguienteLinea()
    {
        if (index < LineasDialogo.Length - 1)
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
}
