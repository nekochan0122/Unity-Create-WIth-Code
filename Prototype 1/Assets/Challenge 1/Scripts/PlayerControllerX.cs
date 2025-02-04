﻿using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    private void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, -verticalInput * rotationSpeed * Time.deltaTime);
    }
}
