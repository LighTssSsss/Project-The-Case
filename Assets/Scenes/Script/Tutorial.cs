using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public float tiempo;
    public bool parte1Desactivada, parte2Desactivada, parte3Desactivada, parte4Desactivada,prendido,botonN,botonF;
    public GameObject uno, dos, tres, cuatro, cinco,objetivo;
    public Animator parte1, parte2,parte3,parte4;
    public GameObject bloqueo;
    public bool tutorialCompletado;
    // public Animator an, ann, annn, anni;
    // Start is called before the first frame update

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        parte1Desactivada = true;
        uno.SetActive(false);
        dos.SetActive(false);
        tres.SetActive(false);
        cuatro.SetActive(false);
        cinco.SetActive(false);
        objetivo.SetActive(false);
        bloqueo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(parte1Desactivada = true && parte2Desactivada == false)
        {
            uno.SetActive(true);
            tiempo += Time.deltaTime;
        }

        if(tiempo >= 7 && parte2Desactivada == false)
        {
            parte2Desactivada = true;
            tiempo = 0;
        }

        else if(parte2Desactivada == true && parte3Desactivada == false)
        {
            parte1.Play("Joystick Desaparece");
            dos.SetActive(true);
            tiempo += Time.deltaTime;
        }

       if(tiempo >= 7 && parte2Desactivada == true && parte3Desactivada == false)
        {
            parte2.Play("DeslizaDesaparece");
            parte3Desactivada = true;
            bloqueo.SetActive(false);
            tiempo = 0;
        }
       
       else if(parte3Desactivada == true)
        {
            tres.SetActive(true);
            tiempo += Time.deltaTime;

        }

       if(tiempo >= 5 && parte3Desactivada == true)
        {
            prendido = true;
            parte3.Play("InventarioDesaparece");
            
            tiempo = 0;
        }

        else if(parte2Desactivada == true && parte3Desactivada == true && prendido == true)
        {
            objetivo.SetActive(true);
            tutorialCompletado = true;
            tiempo = 0;
        }

       if(botonF == true)
        {
            cuatro.SetActive(true);
        }

       if(botonN == true)
        {
            cuatro.SetActive(false);
            cinco.SetActive(true);
           
        }
        
       
    }
    

    public void ReproduceAnimaciones(string nombres)
    {
        parte1.Play(nombres);
        parte2.Play(nombres);
        parte3.Play(nombres);
        parte4.Play(nombres);
    }
}
