using Unity.Cinemachine;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public static CameraSystem Instance;

    private CinemachineCamera _cineCam;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        _cineCam = GetComponentInChildren<CinemachineCamera>();
    }

    public void SetTarget(Transform target)
    {
        _cineCam.Follow = target;
        _cineCam.LookAt = target;
        Debug.Log(_cineCam);
    }
}