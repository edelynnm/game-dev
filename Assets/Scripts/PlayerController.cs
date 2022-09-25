using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed;
    // public Rigidbody rigidBody;
    public float jumpForce;
    public CharacterController controller;
    public float gravityScale;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        // rigidBody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // rigidBody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigidBody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        // if (Input.GetButtonDown("Jump")) // spacebar by default
        // {
        //    rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpForce, rigidBody.velocity.z); 
        // }

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump")) // spacebar by default
            {
                moveDirection.y = jumpForce ;
            }
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
