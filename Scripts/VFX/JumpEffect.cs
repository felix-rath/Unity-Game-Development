using DG.Tweening;
using UnityEngine;

public class JumpEffect : MonoBehaviour, IProjectileEffect
{
    [Header("Properties")]
    [SerializeField] float jumpPower = 3f;
    [SerializeField] float jumpDuration = 1f;
    [SerializeField] int jumpNumber = 1;


    public void Play(Transform target)
    {
        transform.DOJump(target.position, jumpPower, jumpNumber, jumpDuration)
        .SetEase(Ease.InOutQuad);
    }
}
