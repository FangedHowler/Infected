using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadTest : MonoBehaviour
{
    public Rigidbody playerBody;
    public Vector3 playerBounce;
    public float bounceForce;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            playerBody.AddForce(new Vector3(0, 1 * bounceForce, 0), ForceMode.Impulse);
        }
    }
}
