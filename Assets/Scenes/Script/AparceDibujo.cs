using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparceDibujo : MonoBehaviour
{
    public GameObject reco;
    public GameObject dibujo4;
    // Start is called before the first frame update
    void Start()
    {
        dibujo4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ApareceDib();
    }

    public void ApareceDib()
    {
        Recoleccion recolecc = reco.GetComponent<Recoleccion>();
        if(recolecc.comienzaPuzzle == true)
        {
            dibujo4.SetActive(true);
            print("Prende Dibujo");
        }
    }
}
