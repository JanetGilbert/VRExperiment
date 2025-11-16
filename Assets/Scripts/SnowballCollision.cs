using UnityEngine;

public class SnowballCollision : MonoBehaviour
{
    public GameObject snowballParticlePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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

            gameObject.SetActive(false);    
            
        }
    }
}
