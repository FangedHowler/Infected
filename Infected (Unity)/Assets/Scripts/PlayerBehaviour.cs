using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Vector3 playerMovement;
    public float movementSpeed;
    public float speedBoost;
    public bool running;

    public Rigidbody playerBody;
    public bool isGrounded;

    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlayerMove();
        PlayerJump();

        //Player Jump.
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerBody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void PlayerMove()
    {
        playerMovement.x = Input.GetAxis("Horizontal");
        playerMovement.z = Input.GetAxis("Vertical");
        transform.Translate(playerMovement * movementSpeed * Time.deltaTime);

    }
    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerBody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
}
