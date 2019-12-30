using UnityEngine;
using Vuforia;

public class FlashTorch : MonoBehaviour
{
    public void SetFlashTorch(bool enabled)
    {
        Debug.Log($"FlashTorch: {enabled}");
        CameraDevice.Instance.SetFlashTorchMode(enabled);
    } 
}
