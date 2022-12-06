using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform camaraJugador;
    public float velocidadCamara = 10f;
    public Vector3 distancia;
    public Transform mirarJugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Seguimiento();
    }

    void Seguimiento()
    {
        Vector3 dPosicion = camaraJugador.position + distancia;
        Vector3 sPosicion = Vector3.Lerp(transform.position, dPosicion, velocidadCamara * Time.deltaTime);
        transform.position = sPosicion;
        transform.LookAt(mirarJugador.position);
    }
}
