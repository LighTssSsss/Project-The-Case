using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lugar4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objeto4")
        {
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar4 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto4")
        {
            Puzzle1 puz = GameObject.FindObjectOfType<Puzzle1>();
            puz.lugar4 = false;
        }
    }
}
