using DG.Tweening;
using UnityEngine;

public class HoverEffect : MonoBehaviour, IProjectileEffect
{
    [SerializeField] float height = 0.3f;
    [SerializeField] float duration = 2f;
    public void Play(Transform target)
    {
        transform.DOMoveY(transform.position.y + height, duration)
        .SetEase(Ease.InOutSine)
        .SetLoops(-1, LoopType.Yoyo);
    }
}
