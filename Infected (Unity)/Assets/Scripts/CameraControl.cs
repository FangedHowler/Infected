﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float mouseSensitivity;
    public Transform playerBody;
    public Transform target;
    public float distanceFromTarget;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothTime;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    static float yaw;      //Mouse left and right 
    float pitch;    //Mouse up and down

    private void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;

        transform.position = target.position - transform.forward * distanceFromTarget;
    }
}
