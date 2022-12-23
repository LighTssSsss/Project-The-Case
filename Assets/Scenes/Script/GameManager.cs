using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject jugadors;
    public GameObject chica;
    public GameObject cajaPuzzle;
    public bool muerto;
    public CanvasGeneral cG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player jugador = jugadors.GetComponent<Player>();
        MobileCotroller moverse = jugador.GetComponent<MobileCotroller>();
        Modos cambio = jugador.GetComponent<Modos>();
        Recoleccion recoger = jugador.GetComponent<Recoleccion>();
        Dialogo habla = chica.GetComponent<Dialogo>();
        Interaccion puzzleCaja = cajaPuzzle.GetComponent<Interaccion>();

        if (jugador.vidaJugador > 0)
        {
            //Ejecuta todo lo que se tenga que ejecutar aquí.
            moverse.Movimiento();
            cambio.puedoCambiar = false;
            recoger.TomarObjetos();
            habla.DialogosChica();
            puzzleCaja.PuzzleFinal();
            muerto = false;
        }

        else
        {
            
            muerto = true;
            cG.CerrarTodo();
           
        }
    }

    
}
