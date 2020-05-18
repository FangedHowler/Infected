using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestBetterPlayerControl : MonoBehaviour
{
    [Header("Other")]
    public Vector3 playerMovement;
    public bool isGrounded;
    public bool sprintable;
    public bool sprinting;
    public Rigidbody playerBody;

    [Header("Variable values")]
    public float jumpForce;
    public static float moveSpeed;
    public float walkSpeed;
    public float runSpeed;

    [Header("Stamina")]
    public int maxStamina;
    public int currentStamina;
    public int minStamina;
    public PlayerStaminaBar staminaBar;

    void Start()
    {
        playerBody = GetComponent<Rigidbody>();

        currentStamina = maxStamina;
        staminaBar.SetMaxStamina(maxStamina);
        if (currentStamina <= 0)
        {
            currentStamina = minStamina;
        }

        InvokeRepeating("DecreaseStamina", 1.0f, 1.0f);
    }
    void Update()
    {
        //Player 
        playerMovement.x = Input.GetAxis("Horizontal");
        playerMovement.z = Input.GetAxis("Vertical");
        transform.Translate(playerMovement * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
        }
        //Sprint and stamina control
        Sprint();

        if(currentStamina > 0 && isGrounded == true)
        {
            sprintable = true;
        }
        else
        {
            sprintable = false;
        }

        if (currentStamina <= 0)
        {

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
    public void Sprint()
    {
        if (sprintable == true)
        {
            if (Input.GetButton("Fire3"))
            {
                moveSpeed = runSpeed;
                sprinting = true;
            }
            else
            {
                moveSpeed = walkSpeed;
                sprinting = false;
            }
        }

        ReduceStamina();
    }
    public void ReduceStamina()
    {
        if (sprinting == true)
        {
            currentStamina -= 2;
            staminaBar.SetStamina(currentStamina);
        }
        else
        {
            currentStamina += 1;
            staminaBar.SetStamina(currentStamina);
        }
    }
}
