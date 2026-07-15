using DG.Tweening;
using UnityEngine;

public class PunchEffect : MonoBehaviour, IProjectileEffect
{
    [Header("Properties")]
    [SerializeField] float punchRange = 2f;
    [SerializeField] float punchDuration = 1f;

    public void Play(Transform target)
    {
        Vector3 punch = new Vector3(0, Random.Range(0.8f * punchRange, punchRange), 0);
        transform.DOPunchPosition(punch, punchDuration, vibrato: 0);
    }
}
