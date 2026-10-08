 using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) ;
        
        if (Input.GetKeyDown("up"))
        {
            rb.linearVelocity = new Vector3(0, 0, 5);

        }

        if (Input.GetKeyDown("right"))
        {
            rb.linearVelocity = new Vector3(5, 0, 0);
            

        }
        if (Input.GetKeyDown("down"))
        {
            rb.linearVelocity = new Vector3(0, 0, -5);

        }
        if (Input.GetKeyDown("left"))
        {
            rb.linearVelocity = new Vector3(-5, 0, 0);

        }


    }
}
