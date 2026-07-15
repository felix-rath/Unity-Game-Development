using UnityEngine;

public class Player : Entity
{
    public GameObject Orientation;

    public override Vector3 GetForward()
    {
        return Orientation.transform.forward;
    }
}
