using System;
using UnityEngine;

public class HomingProjectile : MonoBehaviour
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
    }

    void FixedUpdate()
    {
        UpdateVelocityMovement();
    }

    void OnTriggerEnter(Collider collider)
    {
        Entity hitTarget = collider.GetComponent<Entity>();
        if (hitTarget == null)
            return;

        if (hitTarget.GetType() == _context.GetTargetType())
        {
            OnHit?.Invoke(_context);
            Destroy(gameObject);
        }
    }

    // -------------- CORE --------------

    // Use rigidbody velocity to permanently move towards the target
    void UpdateVelocityMovement()
    {
        Vector3 direction = (_context.target.transform.position - transform.position).normalized;
        _rb.linearVelocity = direction * speed;
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
