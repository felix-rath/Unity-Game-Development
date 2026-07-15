using UnityEngine;

public static class ProjectileFactory
{
    public static void SpawnProjectile(GameObject projectilePrefab, Vector3 direction)
    {
        
    }

    public static HomingProjectile SpawnHomingProjectile(GameObject prefab, Vector3 spawnPosition, AbilityContext baseContext, Entity target, System.Action<AbilityContext> onHit)
    {
        GameObject instance = Object.Instantiate(prefab, spawnPosition, Quaternion.identity);
        var projectile = instance.GetComponent<HomingProjectile>();
        var ctx = new AbilityContext()
        {
            caster = baseContext.caster,
            target = target,
            abilitySlot = baseContext.abilitySlot
        };

        projectile.Init(ctx);
        projectile.OnHit += onHit;
        return projectile;
    }
}
