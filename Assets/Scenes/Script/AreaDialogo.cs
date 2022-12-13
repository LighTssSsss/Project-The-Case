using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDialogo : MonoBehaviour
{
    [SerializeField] private bool Disponible;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Disponible = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Disponible = false;
        }
    }
}
