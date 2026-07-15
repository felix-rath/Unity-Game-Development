using System;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public event Action<AbilityContext> OnHit;

    [Header("Properties")]
    [SerializeField] float heighOffset = 0.5f;
    [SerializeField] float speed = 20f;

    Rigidbody _rb;
    AbilityContext _context;

    public void Init(AbilityContext context)
    {
        _rb = GetComponent<Rigidbody>();
        _context = context;
        StartProjectileEffects();
        StartVelocityMovement();
    }

    void OnTriggerEnter(Collider collider)
    {
        Entity hitTarget = collider.GetComponent<Entity>();
        if (hitTarget != null)
            _context.target = hitTarget;
        
        OnHit?.Invoke(_context);
    }

    // -------------- CORE --------------

    // Use rigidbody velocity to permanently move forward
    void StartVelocityMovement()
    {
        _rb.linearVelocity = transform.forward * speed;
    }

    void StartProjectileEffects()
    {
        IProjectileEffect[] effects = GetComponentsInChildren<IProjectileEffect>();
        foreach (var e in effects)
        {
            e.Play(_context.target.transform);
        }
    }

}
