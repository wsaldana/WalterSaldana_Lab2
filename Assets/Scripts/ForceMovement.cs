using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour{

    public float force = 7;
    public float jumpForce = 6;
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        if(Input.GetButtonDown("Jump"))
            myJump();
    }

    void FixedUpdate(){
        if (rb)
            rb.AddForce(Input.GetAxis("Horizontal")*force, 0, Input.GetAxis("Vertical")*force);
    }

    private void myJump(){
        if (rb)
            if (Mathf.Abs(rb.velocity.y) < 0.05f && rb.position.y < 2.5f)
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
    }
}
