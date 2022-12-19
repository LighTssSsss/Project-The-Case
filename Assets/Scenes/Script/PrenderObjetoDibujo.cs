using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderObjetoDibujo : MonoBehaviour
{
    public bool puedoTomarlo;
    [SerializeField] private GameObject ImagenTomar;
    public GameObject playerEstado;
    // Start is called before the first frame update
    void Start()
    {
        ImagenTomar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        Modos modPlayer = playerEstado.GetComponent<Modos>();
        Recoleccion recolecc = playerEstado.GetComponent<Recoleccion>();
        if (other.gameObject.tag == "Player" && modPlayer.soyFantasma == false && recolecc.comienzaPuzzle == true)
        {
            Debug.Log("Prendio el objeto");
            ImagenTomar.SetActive(true);
            puedoTomarlo = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ya no prende el objeto");
            ImagenTomar.SetActive(false);
            puedoTomarlo = false;
        }
    }
}
