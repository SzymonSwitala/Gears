using UnityEngine;

public class Gear : MonoBehaviour
{
    [SerializeField] private Gear[] connectedGears;
    private void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * 10f;
        RotateGear(xAxisRotation,this);

    }
    public void RotateGear(float angle,Gear gear)
    {
        transform.Rotate(Vector3.up, angle);

        foreach (Gear connectedGear in connectedGears)
        {
            if (connectedGear==gear)
            {
                continue;
            }
            connectedGear.RotateGear(-angle,this);
        }
    }
}
