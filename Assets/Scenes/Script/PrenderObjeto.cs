using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderObjeto : MonoBehaviour
{
    public bool puedoTomarlo;
    [SerializeField] private GameObject particulas;
    
    // Start is called before the first frame update
    void Start()
    {
        particulas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();

        if(other.gameObject.tag == "Player" )
        {
            Debug.Log("Prendio el objeto");
            particulas.SetActive(true);
            puedoTomarlo = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Modos modoPlayer = GetComponent<Modos>();
        if (other.gameObject.tag == "Player" )
        {
            Debug.Log("Ya no prende el objeto");
            particulas.SetActive(false);
            puedoTomarlo = false;
        }
    }
}
