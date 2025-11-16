using UnityEngine;

public class Snow : MonoBehaviour
{
    [SerializeField] private GameObject cam;

   void Start()
    {
        
    }

    void Update()
    {
         transform.position = cam.transform.position;
    }
}
