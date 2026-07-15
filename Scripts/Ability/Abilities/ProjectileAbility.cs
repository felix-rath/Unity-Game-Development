using UnityEngine;
using DG.Tweening;

public class ProjectileAbility : Ability
{
    [Header("Prefabs")]
    public GameObject projectilePrefab;
    public GameObject hitParticlePrefab;

    [Header("Properties")]
    public float speed = 20f;
    public float punchRange = 1;

    GameObject _projectileInstance;

    void Start()
    {
        _projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation, transform);
        
        // Projectile hit is handled via event to decouple both scripts
        Projectile proj = _projectileInstance.GetComponent<Projectile>();
        proj.Init(_context);
        proj.OnHit += HandleHit;

        StartProjectileShake();
    }

    void OnDestroy()
    {
        // Cleanup events to avoid memory leaks or invalid callbacks
        Projectile proj = _projectileInstance.GetComponent<Projectile>();
        proj.OnHit -= HandleHit;
    }

    // --------------- CORE ---------------

    // Use DotTweening to shake the projectile vfx
    void StartProjectileShake()
    {
        Vector3 punch = new Vector3(Random.Range(-punchRange, punchRange), Random.Range(-punchRange, punchRange), 0);
        float time = Random.Range(0.5f, 1f);
        transform.DOPunchPosition(punch, time, vibrato: 0);
    }

    // Instantiate the explosion / hit particle prefabb
    void SpawnExplosionParticle()
    {
        Instantiate(hitParticlePrefab, _projectileInstance.transform.position, Quaternion.identity);
    }

    protected override void AbilityEnd()
    {
        base.AbilityEnd();
        SpawnExplosionParticle();
    }
}
