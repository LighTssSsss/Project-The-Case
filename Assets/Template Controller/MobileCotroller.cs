using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCotroller : MonoBehaviour
{
    public float velocidadPlayer = 2.0f;
    public float alturaSalto = 1.0f;
    public float gravedad = 9.81f;
    public bool desabilitarControl;
    public Joystick joystick;
    public CharacterController controller;
    
    float velocidadVertical;
    float timerEnSuelo;        // to allow jumping when going down ramps
    bool isGround;
    GameObject camRef;
    public GameObject jug;
    private float inputX;
    private float inputY;
    public Animator animacion;
    private void Start()
    {
        // always add a controller
        camRef = new GameObject();
    }

    void Update()
    {
        /*
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;

        animacion.SetFloat("speedX", inputX);
        animacion.SetFloat("speedY", inputY);
        camRef.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);

        isGround = controller.isGrounded;

        if (isGround)
        {

            timerEnSuelo = 0.2f;
        }
        if (timerEnSuelo > 0)
        {
            timerEnSuelo -= Time.deltaTime;
        }

        if (isGround && velocidadVertical < 0)
        {

            velocidadVertical = 0f;
        }

        velocidadVertical -= gravedad * Time.deltaTime;


        Vector3 move = !desabilitarControl? (joystick.Vertical * camRef.transform.forward) + (joystick.Horizontal * camRef.transform.right) : Vector3.zero;  

        move *= velocidadPlayer;

        if (move.magnitude > 0.05f)
        {
            gameObject.transform.forward = move;
        }

        move.y = velocidadVertical;

        controller.Move(move * Time.deltaTime);*/
    }

    public void Movimiento()
    {
        Dialogo jugg = jug.GetComponent<Dialogo>();

        if(jugg.nopuedeMoverse == false)
        {
            inputX = joystick.Horizontal;
            inputY = joystick.Vertical;

            animacion.SetFloat("speedX", inputX);
            animacion.SetFloat("speedY", inputY);
            camRef.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);

            isGround = controller.isGrounded;

            if (isGround)
            {

                timerEnSuelo = 0.2f;
            }
            if (timerEnSuelo > 0)
            {
                timerEnSuelo -= Time.deltaTime;
            }

            if (isGround && velocidadVertical < 0)
            {

                velocidadVertical = 0f;
            }

            velocidadVertical -= gravedad * Time.deltaTime;


            Vector3 move = !desabilitarControl ? (joystick.Vertical * camRef.transform.forward) + (joystick.Horizontal * camRef.transform.right) : Vector3.zero;

            move *= velocidadPlayer;

            if (move.magnitude > 0.05f)
            {
                gameObject.transform.forward = move;
            }

            move.y = velocidadVertical;

            controller.Move(move * Time.deltaTime);
        }
        /*
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;

        animacion.SetFloat("speedX", inputX);
        animacion.SetFloat("speedY", inputY);
        camRef.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);

        isGround = controller.isGrounded;

        if (isGround)
        {

            timerEnSuelo = 0.2f;
        }
        if (timerEnSuelo > 0)
        {
            timerEnSuelo -= Time.deltaTime;
        }

        if (isGround && velocidadVertical < 0)
        {

            velocidadVertical = 0f;
        }

        velocidadVertical -= gravedad * Time.deltaTime;


        Vector3 move = !desabilitarControl ? (joystick.Vertical * camRef.transform.forward) + (joystick.Horizontal * camRef.transform.right) : Vector3.zero;

        move *= velocidadPlayer;

        if (move.magnitude > 0.05f)
        {
            gameObject.transform.forward = move;
        }

        move.y = velocidadVertical;

        controller.Move(move * Time.deltaTime);*/
    }

    public void Saltar()
    {
        if (desabilitarControl) return;
        if (timerEnSuelo > 0)
        {
            timerEnSuelo = 0;
            velocidadVertical += Mathf.Sqrt(alturaSalto * 2 * gravedad);
        }
    }
}
