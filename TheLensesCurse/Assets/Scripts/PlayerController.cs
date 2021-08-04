using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb = null;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float maxSpeed = 50.0f;
    [SerializeField] Transform CameraTransform = null;

    [SerializeField] GameManager gm = null;

    private void Start()
    {
        Cursor.visible = false;    
    }

    void Update()
    {
        if (!gm.isPaused)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddRelativeForce((speed * Vector3.forward) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddRelativeForce((speed * Vector3.back) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddRelativeForce((speed * Vector3.left) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddRelativeForce((speed * Vector3.right) * Time.deltaTime);
            }

            if(rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }


            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
            CameraTransform.Rotate(Vector3.left * Input.GetAxis("Mouse Y"));
        }
    }
}
