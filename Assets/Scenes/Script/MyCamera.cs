using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Joystick camaraJoystick;

    public Transform jugadorMira;

    [SerializeField] private float distanciaCamara = 10f;
    private float currentX = 0f;
    private float currentY = 0f;

    [SerializeField] private float sensivityX = 3f;
    [SerializeField] private float sensivitY = 1f;
    public float minRotX, maxRotX;
    // Update is called once per frame
    void Update()
    {
        currentX += camaraJoystick.Direction.x * sensivityX;
        currentY -= camaraJoystick.Direction.y * sensivitY;
    }

    private void LateUpdate()
    {
        Vector3 direction = new Vector3(0, 0, -distanciaCamara);
        Quaternion rotacion = Quaternion.Euler(currentY, currentX, 0);
        transform.position = jugadorMira.position + rotacion * direction;
        transform.LookAt(jugadorMira);

        Vector3 eulerAngle = transform.localEulerAngles;

        eulerAngle.x = Mathf.Clamp(eulerAngle.x, minRotX, maxRotX);
       // transform.localEulerAngles = eulerAngle;
    }
}
