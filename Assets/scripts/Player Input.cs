using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{

public bool disabled = false;

    private Rigidbody rb;

    bool isGrounded = false;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 5f;

    private Vector2 direction = Vector2.zero;

    // dash vars
    // private bool canDash = true;
    // private bool isDashing;
    // private float dashingPower = 24f;
    // private float dashingTime = 0.2f;
    // private float dashingCooldown = 1f;

    // [SerializeField] private TrailRender tr = 0f;




    void Start()
    {
        rb = GetComponent<Rigidbody>(); //collect the players rigidbody and save it in rb

    }

    // OnMove is called when key is hit
    void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        Debug.Log(direction);
        this.direction = direction;

    }

    void Update()
    {
        // if(isDashing)
        // {
        //     return;
        // }

        Move(direction.x, direction.y);

        // if(Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        // {
        //     StartCoroutine(Dash());
        // }
    }


    // private void FixedUpdate()
    // {
    //     if(isDashing)
    //     {
    //         return;
    //     }
    // }

    private void Move(float x, float z) //z is the 
    {
        rb.velocity = new Vector3(x*speed, rb.velocity.y, z*speed);
    }

    void OnJump()
    {
        if(isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        Debug.Log(rb.velocity);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log(isGrounded);
        isGrounded = false;
    }

    void OnCollisionStay(Collision collision)
    {

        if(Vector3.Angle(collision.GetContact(0).normal, Vector3.up) < 45f)
        {
            isGrounded = true;
        } else {
            isGrounded = false;
        }
    }


    // private IEnumerator Dash()
    // {
    //     canDash = false;
    //     isDashing = true;
    //     // float originalGravity = rb.gravityScale;
    //     // rb.gravityScale = 0f;
    //     rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
    //     // tr. emitting = true;
    //     yield return new WaitForSeconds(dashingTime);
    //     // tr.emitting = false;
    //     // rb.gravityScale = originalGravity;
    //     isDashing = false;
    //     yield return new WaitForSeconds(dashingCooldown);
    //     canDash = true;

    // }
}







