using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modos : MonoBehaviour
{
    public bool soyFantasma;
    public bool soyNormal;
    // Start is called before the first frame update
    void Start()
    {
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
        soyNormal = false;
        soyFantasma = true;
    }

    public void BotonCuerpo()
    {
        Debug.Log("Soy humano");
        soyNormal = true;
        soyFantasma = false;
    }
}
