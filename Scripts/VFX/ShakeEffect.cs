using System;
using DG.Tweening;
using UnityEngine;

public class ShakeEffect : MonoBehaviour, IProjectileEffect
{
    [Header("Properties")]
    [SerializeField] float shakeDuration = 5f;
    [SerializeField] float shakeStrength = 3f;
    [SerializeField] int shakeVibrato = 2;



    public void Play(Transform target)
    {
        transform.DOShakePosition(shakeDuration, shakeStrength, shakeVibrato);
    }
}
