using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChoqueGuardianes : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI textoDialogo;
    public TextMeshProUGUI textoNombre;
    public string texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        CanvasGeneral can = canvas.GetComponent<CanvasGeneral>();
        if (collision.gameObject.tag == "Player")
        {
            textoNombre.text = "Abogado:";
            textoDialogo.text = texto;

            can.dialogo.SetActive(true);
            print("prende");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        CanvasGeneral can = canvas.GetComponent<CanvasGeneral>();
        if (collision.gameObject.tag == "Player")
        {
            can.dialogo.SetActive(false);
            print("Apaga");
        }
    }
}
