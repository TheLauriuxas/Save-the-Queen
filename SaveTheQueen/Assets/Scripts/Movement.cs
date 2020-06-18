using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpHeight = 5f;

    public bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
            Vector3 horizontalMovement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //1f, 0f, 0f, Left, right movement.
            transform.position += horizontalMovement * Time.deltaTime * playerSpeed;

            Vector3 verticalMovement = new Vector3(0f, 0f, Input.GetAxis("Vertical"));//0f, 0f, 1f, up, down movement.
            transform.position += verticalMovement * Time.deltaTime * playerSpeed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
