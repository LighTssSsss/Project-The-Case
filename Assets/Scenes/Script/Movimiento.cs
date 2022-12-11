using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadJugador;
    public bool desactivarControl;
    public Joystick joystickMovimiento;
    public CharacterController controlador;

    float velocidadVertical;
    GameObject referenciaCamara;

    // Start is called before the first frame update
    void Start()
    {
        referenciaCamara = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
    }

    public void MovimientoJugador()
    {
        referenciaCamara.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);
        Vector3 movimiento = !desactivarControl ? (joystickMovimiento.Vertical * referenciaCamara.transform.forward) + (joystickMovimiento.Horizontal * referenciaCamara.transform.right) : Vector3.zero;
        movimiento *= velocidadJugador;
        if (movimiento.magnitude > 0.05f)
        {
            gameObject.transform.forward = movimiento;
        }

        movimiento.y = velocidadVertical;

        controlador.Move(movimiento * Time.deltaTime);
    }

    public void MovimientoDos()
    {
        
    }
}
