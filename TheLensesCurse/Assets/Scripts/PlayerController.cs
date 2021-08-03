using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb = null;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float maxSpeed = 50.0f;
    [SerializeField] Transform CameraTransform = null;

    private void Start()
    {
        Cursor.visible = false;    
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(speed * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(speed * Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(speed * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(speed * Vector3.right);
        }

        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }


        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
        CameraTransform.Rotate(Vector3.left * Input.GetAxis("Mouse Y"));
    }
}
