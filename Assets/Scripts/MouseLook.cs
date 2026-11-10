using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 2f;
    [SerializeField] Transform playerCamera;
    public float minPitch = -30f;
    public float maxPitch = 60f;


    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
    
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, minPitch, maxPitch);

    }

    private void LateUpdate()
    {
        playerCamera.localRotation =
            Quaternion.Euler(xRotation, 0f, 0f);
        
    }



}