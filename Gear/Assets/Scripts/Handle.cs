using UnityEngine;

public class Handle : MonoBehaviour
{
    [SerializeField] private Gear gear;
    [SerializeField] private float mouseSensitivity=10f;

    private void OnMouseDrag()
    {     
            float xAxisRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
            gear.RotateGear(xAxisRotation, gear);      
    }
}
