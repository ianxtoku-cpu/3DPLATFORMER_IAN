using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Ray ray;
    LayerMask mask;
    
    RaycastHit hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, .5f));
        print(ray);

        if (Physics.Raycast(ray, out RaycastHit hit, 10f, 1 << 8))
        {
            print(hit.collider.gameObject.name);
        }


    }
        
    }

