using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Rigidbody myRb;

    public float moveSpeed;
    public float jumpForce;
    private float dirX;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (Input.GetButtonDown("Jump"))//jump
        {
            Jump();
        }

    }
    private void FixedUpdate()
    {
        Movement(dirX);
    }

    //horizontal movement
    private void Movement(float Dir)
    {
        myRb.velocity = new Vector3(Dir, myRb.velocity.y, myRb.velocity.z);
    }

    private void Jump()
    {
        myRb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }

}
