using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    public GameObject sonidoPresionar;



    public void sonidoPresiona()
    {
        Instantiate(sonidoPresionar);
    }
}
