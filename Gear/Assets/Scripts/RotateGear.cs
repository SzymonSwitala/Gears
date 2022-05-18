using UnityEngine;

public class RotateGear : MonoBehaviour
{
    [SerializeField] private Gear gear;
    [SerializeField] private float speed=1;

    private void Update()
    {
        gear.RotateGear(speed*Time.deltaTime,gear);
    }
}
