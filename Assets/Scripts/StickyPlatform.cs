using UnityEngine;

public class StickyPlatform : MonoBehaviour



{
    Vector3 lastPosition;
    Rigidbody playerRb;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerRb = collision.rigidbody;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerRb = null;

        }
    }

    private void Start()
    {
        lastPosition = transform.position;

    }
    private void FixedUpdate()
    {
        Vector3 platformMove = transform.position - lastPosition;

        if (playerRb != null)
        {
            playerRb.MovePosition(playerRb.position + platformMove);


        }
        lastPosition = transform.position;
    }




}



