using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Values")]
    public float moveSpeed;
    public float walkSpeed;
    public float runSpeed;
    public float jumpForce;
    
    [Header("Other")]
    public Rigidbody playerBody;
    public Vector3 playerMovement;
    public bool isGrounded;
    public bool sprintable;
    public void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        playerMovement.x = Input.GetAxis("Horizontal");
        playerMovement.z = Input.GetAxis("Vertical");
        transform.Translate(playerMovement * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
            sprintable = false;
        }
        Sprint();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
            sprintable = true;
        }
    }
    public void Sprint()
    {
        if (sprintable == true)
        {
            if (Input.GetButton("Fire3"))
            {
                moveSpeed = runSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }
        }
    }
}
