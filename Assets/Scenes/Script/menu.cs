using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Animator animacionMenu;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    

    public void Comenzar()
    {
        Invoke("CambiameEscena", 1f);
        ReproducirAnimacionMenu("FadeOutMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }


    public void ReproducirAnimacionMenu(string nombMenu)
    {
        animacionMenu.Play(nombMenu);
    }

    public void CambiameEscena()
    {
        SceneManager.LoadScene(1);
    }
}
