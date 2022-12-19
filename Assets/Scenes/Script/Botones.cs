using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    [SerializeField] private Light luz;
    [SerializeField] private bool encendida;
    

    private void Start()
    {
        this.encendida = false;
        luz.enabled = false;
    }

    public void EncenderLuz(bool enc)
    {
        this.encendida = enc;
        luz.enabled = enc;
    }

    public void ApagarLuz(bool apg)
    {
        this.encendida = apg;
        luz.enabled = apg;
    }
}
