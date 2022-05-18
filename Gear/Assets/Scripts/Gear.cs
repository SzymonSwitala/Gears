using UnityEngine;

public class Gear : MonoBehaviour
{
    [SerializeField] private Gear[] connectedGears;

    public void RotateGear(float angle, Gear gear)
    {
        transform.Rotate(Vector3.up, angle);

        foreach (Gear connectedGear in connectedGears)
        {
            if (connectedGear == gear)
            {
                continue;
            }
            connectedGear.RotateGear(-angle, this);
        }
    }
}
