using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBetterPlayerControl : MonoBehaviour
{
    public Vector3 playerMovement;
    public float speed;
    public bool isGrounded;
    public float gravity;
    public Rigidbody playerBody;
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        playerMovement.x = Input.GetAxis("Horizontal");
        playerMovement.z = Input.GetAxis("Vertical");
        transform.Translate(playerMovement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
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
