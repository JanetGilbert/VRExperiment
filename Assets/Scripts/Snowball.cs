using UnityEngine;

public class SnowballCollision : MonoBehaviour
{
    public GameObject snowballParticlePrefab;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Snowball" && collision.gameObject.tag != "Plane")
        {
            Debug.Log("Snowball collided with: " + collision.gameObject.name);
            // Spawn snow particle system at location of collision
            if (snowballParticlePrefab != null)
            {
                Instantiate(snowballParticlePrefab, collision.contacts[0].point, Quaternion.identity);
            }

            //gameObject.SetActive(false);    

            // Restore position and rotation
            transform.position = originalPosition;
            transform.rotation = originalRotation;

            // Reset velocity 
            Rigidbody rb = GetComponent<Rigidbody>();       
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
