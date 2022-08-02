using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rb;
    private bool canJump;
    [SerializeField] float jumpForce;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        Debug.DrawLine(transform.position, groundCheck.position, Color.red);

        if (grounded)
        {
            canJump = true;
        }else
        { canJump = false;
        }

        if (Input.GetButtonDown("Jump")&& canJump)
        {
            rb.AddForce(Vector3.up * 500);
        }
    }
}
