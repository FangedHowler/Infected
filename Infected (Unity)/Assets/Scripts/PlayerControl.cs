﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Player")]
    //public float lowspeed;
    //public float rotSpeed;
    //public float jumpSpeed;
    //public float gravity;

    //private Vector3 moveDir = Vector3.zero;
    


    [Header("FinalTest")]
    private CharacterController playerController;
    public Vector3 playerMove;
    public float speed;

    public void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    //public void LateUpdate()
    //{

        //moveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
        //moveDir = transform.TransformDirection(moveDir);
        //moveDir *= speed;
        //if (Input.GetButtonDown("Jump"))
        //{
            //moveDir.y = jumpSpeed;
        //}
        //else
        //{
           // moveDir = new Vector3(0, moveDir.y, Input.GetAxis("Vertical"));
           // moveDir = transform.TransformDirection(moveDir);
           // moveDir.x *= speed;
           // moveDir.z *= speed;
        //}

        //transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        //moveDir.y -= gravity * Time.deltaTime;
        //playerController.Move(moveDir * Time.deltaTime);
    //}
}