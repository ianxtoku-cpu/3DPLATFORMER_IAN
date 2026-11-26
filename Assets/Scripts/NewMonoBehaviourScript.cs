using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Ray ray;
    LayerMask Grappleable;
    public float maxGrappleDistance;
    public float grappleDelayTime;

    private Vector3 grapplePoint;
    [Header("Cooldown")]
    public float grapplingCd;

    [Header("Input")]
    public KeyCode grappleKey = KeyCode.Mouse1;
    RaycastHit hit;
    
    
    private void StartGrapple()
    {

    }
    private void ExecuteGrapple()
    {

    }
    
    void Start()
    {
        PhysicMaterial = GetComponent<PlayerMovementGrappling>();
    }

    // Update is called once per frame
    void Update()
    {

    }
        
    }

