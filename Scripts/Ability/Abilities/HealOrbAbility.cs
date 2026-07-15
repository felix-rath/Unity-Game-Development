using UnityEngine;
using DG.Tweening;

public class HealOrbAbility : Ability
{
    [Header("Prefabs")]
    public GameObject healOrbPrefab;
    public GameObject projectilePrefab;

    [Header("Properties")]
    public float radius = 8f; // NICHT ÄNDERN IST GENAU SO WIE VFX RING ERSTMAL!
    public float healCd = 2f;


    float healTimer;
    GameObject _healOrbInstance;

    void Start()
    {
        SpawnHealOrb();
        StartProjectileSearch();
    }

    void Update()
    {
        UpdateProjectileTimer();
    }

    // -------------- CORE --------------

    // Instantiate the heal orb
    void SpawnHealOrb()
    {
        _healOrbInstance = Instantiate(healOrbPrefab, transform.position, Quaternion.identity, transform);
        _healOrbInstance.GetComponentInChildren<HoverEffect>().Play(_context.caster.transform);
        healTimer = healCd;
    }

    // Use ProjectileFactory to setup and spawn the heal projectile
    void SpawnHealProjectile(Entity target)
    {
        if (target == null)
            return;
        
        HomingProjectile hProjectile = ProjectileFactory.SpawnHomingProjectile(
        prefab: projectilePrefab,
        spawnPosition: _healOrbInstance.transform.position,
        baseContext: _context,
        target: target,
        onHit: HandleHit);
    }

    // Use TargetFinder to get multiple targets inside a radius
    void StartProjectileSearch()
    {
        Entity[] targets = TargetFinder.SphereFinder(_healOrbInstance.transform.position, radius, _context.GetTargetType());
        for (int i = 0; i < targets.Length; i++)
        {
            SpawnHealProjectile(targets[i]);
        }
    }

    // Update the projectile spawn timer/cooldown to spawn a projectile
    void UpdateProjectileTimer()
    {
        healTimer -= Time.deltaTime;
        if (healTimer <= 0)
        {
            healTimer = healCd;
            StartProjectileSearch();
        }
    }

    // For now empty to override/stop the standard ability destroy
    protected override void AbilityEnd()
    {
    }
}
