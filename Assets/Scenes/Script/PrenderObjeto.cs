using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderObjeto : MonoBehaviour
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


    private void OnTriggerStay(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        Modos modPlayer = playerEstado.GetComponent<Modos>();

        if (other.gameObject.tag == "Player" && modPlayer.soyFantasma == false)
        {
            Debug.Log("Prendio el objeto");
            ImagenTomar.SetActive(true);
            puedoTomarlo = true;

        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        Modos modPlayer = playerEstado.GetComponent<Modos>();

        if(other.gameObject.tag == "Player" && modPlayer.soyFantasma == false)
        {
            Debug.Log("Prendio el objeto");
            ImagenTomar.SetActive(true);
            puedoTomarlo = true;
           
        }
    }*/

    private void OnTriggerExit(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        if (other.gameObject.tag == "Player" )
        {
            Debug.Log("Ya no prende el objeto");
            ImagenTomar.SetActive(false);
            puedoTomarlo = false;
        }
    }
}
