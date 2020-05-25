using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls: MonoBehaviour
{
    public float mouseSensitivity = 200f;
    public Transform playerBody;

    public Transform target;
    float xRotation = 0f;
    public float distanceFromTarget;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, 0, 85f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        transform.position = target.position - transform.forward * distanceFromTarget;
    }
}
