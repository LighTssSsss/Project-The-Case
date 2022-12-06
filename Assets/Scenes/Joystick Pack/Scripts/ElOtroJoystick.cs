using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElOtroJoystick : MonoBehaviour
{
    public Joystick elJoystick;

    public float horizontal, vertical;

    private void Update()
    {
        horizontal = elJoystick.Horizontal;
        vertical = elJoystick.Vertical;
    }

}


