using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private void Update()
    {
        var rotation = transform.rotation;
        Debug.Log(rotation);
    }
}