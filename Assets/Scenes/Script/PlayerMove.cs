using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Joystick joystickMovi;

    private float inputX;
    private float inputY;

    //-------------
    [SerializeField] private float velocidadDeMovimiento;
    [SerializeField] private float velocidadDeRotacion;

    private Rigidbody rgbd;

    [SerializeField] private Animator animacionJugador;
    private Vector3 moviVector;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        /*
        currentX += joystickCamara.Direction.x * sensivityX;
        currentY -= joystickCamara.Direction.y * sensivitY; */
    }

  

    public void Movimiento()
    {
        inputX = joystickMovi.Horizontal;
        inputY = joystickMovi.Vertical;

        animacionJugador.SetFloat("speedX", inputX);
        animacionJugador.SetFloat("speedY", inputY);

        rgbd.velocity = new Vector3(joystickMovi.Horizontal * velocidadDeMovimiento, rgbd.velocity.y, joystickMovi.Vertical * velocidadDeMovimiento);

        if(joystickMovi.Horizontal != 0 || joystickMovi.Vertical != 0)
        {
           
            transform.rotation = Quaternion.LookRotation(rgbd.velocity);
        }

        else if (joystickMovi.Horizontal == 0 || joystickMovi.Vertical == 0)
        {
            // Idle
        }
        rgbd.MovePosition(rgbd.position+ moviVector);
    }
}
