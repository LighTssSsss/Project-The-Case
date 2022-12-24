using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public GameObject guardian;
    public bool lugar1, lugar2, lugar3,lugar4;
    private SonidoManager sonidoManager;
    public GameObject sonido;
    private void Awake()
    {
        sonidoManager = FindObjectOfType<SonidoManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        sonido.SetActive(false);
        guardian.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(lugar1 == true && lugar2 == true && lugar3 == true && lugar4 == true)
        {
            sonido.SetActive(true);
            guardian.SetActive(false);
        }
    }
}
