// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem;

// public class Dashing : MonoBehaviour
// {
//     [Header("References")]
//     public Transform orientation;
//     public Transform playerCam;
//     private Rigidbody rb;
//     // private PlayerMovementDashing pm;

//     [Header("Dashing")]
//     public float dashForce;
//     public float dashUpwardForce;
//     public float dashDuration;

//     [Header("Cooldown")]
//     public float dashCd;
//     private float dashCdTimer;

//     [Header("Input")]
//     public KeyCode dashKey = KeyCode.E;

//     // Start is called before the first frame update
//     void Start()
//     {
//        rb.GetComponent<Rigidbody>();
//        // pm = GetComponent<PlayerMovementDashing>();
//     }

//     // Update is called once per frame
//     private void OnDash()
//     {
//         Dash();
        
//     }

//     private void Dash()
//     {
//         Vector3 forceToApply = orientation.forward * dashForce + orientation.up * dashUpwardForce;
//         rb.AddForce(forceToApply, ForceMode.Impulse);

//         // Invoke(nameof(ResetDash), dashDuration);
//     }


// }
