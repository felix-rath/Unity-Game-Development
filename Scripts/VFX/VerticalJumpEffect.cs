using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class VerticalJumpEffect : MonoBehaviour, IProjectileEffect
{
    [Header("Properties")]
    [SerializeField] float jumpDuration = 1f;
    [SerializeField] float jumpPower = 3f;
    
    public void Play(Transform target)
    {
        float half = jumpDuration * 0.5f;

        transform.DOLocalMoveY(jumpPower, half)
        .SetLoops(2, LoopType.Yoyo)
        .SetEase(Ease.OutQuad);
    }
}
