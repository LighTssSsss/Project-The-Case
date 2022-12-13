using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modos : MonoBehaviour
{
    public bool soyFantasma;
    public bool soyNormal;
    public GameObject fantasma;
    public GameObject humano;
    // Start is called before the first frame update
    void Start()
    {
        fantasma.SetActive(false);
        humano.SetActive(true);
        soyNormal = true;
        soyFantasma = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonFantasma()
    {
        Debug.Log("Soy Fantasma buuuuu");
        fantasma.SetActive(true);
        humano.SetActive(false);
        soyNormal = false;
        soyFantasma = true;
    }

    public void BotonCuerpo()
    {
        fantasma.SetActive(false);
        humano.SetActive(true);
        Debug.Log("Soy humano");
        soyNormal = true;
        soyFantasma = false;
    }
}
