using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public float tiempo;
    public bool estad, estad2, estad3, estad4, estad5;
    public GameObject uno, dos, tres, cuatro, cinco;
    public Animator an, ann, annn, anni;
    // Start is called before the first frame update
    void Start()
    {
        estad = true;
        uno.SetActive(false);
        dos.SetActive(false);
        tres.SetActive(false);
        cuatro.SetActive(false);
        cinco.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(estad = true)
        {
            uno.SetActive(true);
        }
    }

    public void ReproduceAnimaciones(string nombres)
    {
        an.Play(nombres);
        ann.Play(nombres);
        annn.Play(nombres);
        anni.Play(nombres);
    }
}
