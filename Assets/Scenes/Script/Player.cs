using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image barraDeVida;

    [SerializeField] private float vidaJugadorMaxima;
    [SerializeField] private float vidaJugador;
    public float tiempo;
    public GameObject estados;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        BarraDeVida();
        Estados();
    }

    public void BarraDeVida()
    {
        barraDeVida.fillAmount = vidaJugador / vidaJugadorMaxima;
    }


    void Estados()
    {
        Modos estad = estados.GetComponent<Modos>();

        if (estad.soyFantasma == true)
        {
            
            tiempo += Time.deltaTime;
            if(tiempo >= 2)
            {
                vidaJugador -= 5;
                tiempo = 0;
            }
            
        }


        if(estad.soyNormal == true && vidaJugador < 100)
        {
           
            tiempo += Time.deltaTime;

            if(tiempo >= 3 && vidaJugador >= 1)
            {
                vidaJugador += 5;
                tiempo = 0;
            }
            
        }
    }

    void RecolectoObjetos()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

   
}
