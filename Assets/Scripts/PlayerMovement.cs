 using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        

        
        rb = GetComponent<Rigidbody>();
      
    }
    
    // Update is called once per frame
    void Update()
    {
        

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        bool moving = horizontalInput != 0 || verticalInput != 0;
        anim.SetBool("isRunning", moving && IsGrounded());


        if (Input.GetButtonDown("Jump")&& IsGrounded() )
        {
            Jump();


        }


        Vector3 move = transform.right * horizontalInput
              + transform.forward * verticalInput;
        move = Vector3.ClampMagnitude(move, 1f);

        rb.linearVelocity = new Vector3(move.x * movementSpeed, rb.linearVelocity.y, move.z * movementSpeed);
        


    }
   void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
        anim.SetBool("Jump");
    }



    private  void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }


    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }


}
