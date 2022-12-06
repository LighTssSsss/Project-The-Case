using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    //Transform cam;
    public Joystick JoystickMove;
    //public Joystick JoystickGiro;
    public Transform jugador;
    public CharacterController control;

    public float velocidadMovimiento = 10f;
    public float velociadDeGiro = 0.2f;
    float x;
    float z;
    Vector3 movimiento;

    float rotarH;
    float rotarV;

    private float inputX;
    private float inputY;
    [SerializeField] private Animator animacionJugador;
    [SerializeField] private Rigidbody rgbd;
    //public FixedJoystick joystickRotaCamara;
    public float CamaraAngulo;
    public float CamaraAnguloVelocidad;


    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
       // cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //RotarCamara();
    }


    void Move()
    {
        inputX = JoystickMove.Horizontal;
        inputY = JoystickMove.Vertical;

        animacionJugador.SetFloat("speedX", inputX);
        animacionJugador.SetFloat("speedY", inputY);

        rgbd.velocity = new Vector3(JoystickMove.Horizontal * velocidadMovimiento, rgbd.velocity.y, JoystickMove.Vertical * velocidadMovimiento);

        if (JoystickMove.Horizontal != 0 || JoystickMove.Vertical != 0)
        {

            transform.rotation = Quaternion.LookRotation(rgbd.velocity);
        }

        

        rgbd.MovePosition(rgbd.position + movimiento);

        

        /*
        x = JoystickMove.Horizontal + Input.GetAxis("Horizontal");
        z = JoystickMove.Vertical + Input.GetAxis("Vertical"); */
        movimiento = jugador.right * x + jugador.forward * z;
        

        //control.Move(movimiento * velocidadMovimiento * Time.deltaTime);
    }

    /*void RotarCamara()
    {
        rotarH = JoystickGiro.Horizontal * velociadDeGiro;
        rotarV = JoystickGiro.Vertical * velociadDeGiro;
        cam.Rotate(rotarV, 0, 0);
        cam.Rotate(0, rotarH, 0);
    }*/
}
