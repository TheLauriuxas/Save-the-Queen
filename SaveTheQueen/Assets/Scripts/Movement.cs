using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpHight = 5f;

    public bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * playerSpeed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpHight, 0f), ForceMode.Impulse);
        }
    }
}
