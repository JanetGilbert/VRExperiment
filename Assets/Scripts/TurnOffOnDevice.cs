using UnityEngine;
using UnityEngine.XR.Management;

public class TurnOffOnDevice : MonoBehaviour
{
    private void Awake()
    {
        if (XRGeneralSettings.Instance != null && XRGeneralSettings.Instance.Manager != null)
        {
            if (XRGeneralSettings.Instance.Manager.activeLoader != null)
            {
                // An XR device is detected and active.
                // You can further check the type of activeLoader if needed for specific device detection.
                Debug.Log("Unity is running on an active XR device (likely Meta Quest).");
                gameObject.SetActive(false);
            }
            else
            {
                // No active XR device found.
                Debug.Log("Unity is running without an active XR device (e.g., in editor or on a desktop).");
            }
        }
        else
        {
            Debug.LogWarning("XRGeneralSettings or XRManager is not initialized.");
        }
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
