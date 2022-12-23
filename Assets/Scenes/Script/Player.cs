using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image barraDeVida;

    [SerializeField] private float vidaJugadorMaxima;
    public float vidaJugador;
    public float tiempo;
    public GameObject estados;
    public Animator animacion;
    public CharacterController charc;

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
                vidaJugador -= 20;
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

        if(vidaJugador <= 0)
        {
            ReproduceLaAnimacionMuerte("Standing React Death Forward");
            charc.enabled = false;
            gameObject.layer = 13;
        }
    }

    
    public void ReproduceLaAnimacionMuerte(string nombreAni)
    {
        animacion.Play(nombreAni);
    }

   
}
