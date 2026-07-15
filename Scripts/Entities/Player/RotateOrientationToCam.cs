using UnityEngine;

public class RotateOrientationToCam : MonoBehaviour
{
    void Update()
    {
        Vector3 newRot = new Vector3(
        transform.eulerAngles.x,
        Camera.main.transform.eulerAngles.y,
        transform.eulerAngles.z
        );

        transform.rotation = Quaternion.Euler(newRot);
    }
}
