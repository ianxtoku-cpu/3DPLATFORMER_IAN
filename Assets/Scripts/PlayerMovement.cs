 using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        if (Input.GetButtonDown("Jump")&& IsGrounded() )
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);

        }


        rb.linearVelocity = new Vector3(horizontalInput * movementSpeed, rb.linearVelocity.y, verticalInput * movementSpeed);
        


    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }


    


}
