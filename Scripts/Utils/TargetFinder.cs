using System.Linq;
using UnityEngine;

public static class TargetFinder
{
    public static Entity[] SphereFinder(Vector3 position, float radius, System.Type type)
    {
        Collider[] hits = Physics.OverlapSphere(position, radius);

        Entity[] temp = new Entity[hits.Length];
        int count = 0;

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].TryGetComponent<Entity>(out var entity))
            {
                if (entity.GetType() == type)
                    temp[count++] = entity;
            }
        }

        System.Array.Resize(ref temp, count);
        return temp;
    }
}
