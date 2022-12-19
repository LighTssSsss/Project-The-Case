using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    [SerializeField] private Light luz;
    [SerializeField] private bool encendida;
    [SerializeField] private bool apagado;


    private void Start()
    {
        this.encendida = false;
        luz.enabled = false;
    }

    private void Update()
    {
        
    }
    public void EncenderLuz(bool enc)
    {
        this.encendida = enc;
        luz.enabled = enc;
    }


}
