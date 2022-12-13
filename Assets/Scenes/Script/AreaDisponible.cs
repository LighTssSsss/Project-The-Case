using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDisponible : MonoBehaviour
{
    public bool disponible;
    [SerializeField] private Transform ubicacionObjetoEncima;
    [SerializeField] private GameObject objeto;

    private void Start()
    {
        objeto.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            disponible = true;
            objeto.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            disponible = false;
            objeto.SetActive(false);
        }
    }
}