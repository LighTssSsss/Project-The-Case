using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDisponible : MonoBehaviour
{
    public bool disponible;
    [SerializeField] private Transform ubicacionObjetoEncima;
    [SerializeField] private GameObject objeto,objeto2;
    public GameObject jugadors;
    public bool aparece;

    private void Start()
    {
        objeto.SetActive(false);
        objeto2.SetActive(false);
    }

    private void Update()
    {
        if(aparece == true)
        {
            objeto.SetActive(false);
            objeto2.SetActive(false);
        }
    }

    
    
    private void OnTriggerStay(Collider other)
    {
        Modos modd = jugadors.GetComponent<Modos>();
        if (other.gameObject.tag == "Player" && modd.soyFantasma == false)
        {
            disponible = true;
            if(aparece == false)
            {
                objeto.SetActive(true);
                objeto2.SetActive(true);
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            disponible = false;
            aparece = false;
            objeto.SetActive(false);
            objeto2.SetActive(false);
        }
    }
}
