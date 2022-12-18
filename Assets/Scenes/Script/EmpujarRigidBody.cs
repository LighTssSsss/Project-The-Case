using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujarRigidBody : MonoBehaviour
{
    public float poderEmpuje = 2.0f;
    private float targetMasa;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody cuerpo = hit.collider.attachedRigidbody;

        if(cuerpo == null || cuerpo.isKinematic)
        {
            return;
        }

        if(hit.moveDirection.y < -0.3)
        {
            return;
        }
        targetMasa = cuerpo.mass;

        Vector3 direcionEmpuje = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        cuerpo.velocity = direcionEmpuje * poderEmpuje / targetMasa;
    }

   
}
