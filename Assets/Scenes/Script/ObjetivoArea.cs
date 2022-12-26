using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetivoArea : MonoBehaviour
{
    public string objetivo;
    public TextMeshProUGUI textoObjetivo;
    public bool entro;
    public GameObject area;


    private void Start()
    {
        area.SetActive(true);
    }

    private void Update()
    {
        NuevoObjetivo();
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textoObjetivo.text = objetivo;
            entro = true;
            //area.SetActive(false);
        }
    }

    public void NuevoObjetivo()
    {
        if(entro == true)
        {
            textoObjetivo.text = objetivo;
        }
    }
}
