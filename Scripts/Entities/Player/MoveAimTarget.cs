using UnityEngine;

public class MoveAimTarget : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.transform.position + (Camera.main.transform.forward * 100);
        transform.position = newPos;
    }
}
