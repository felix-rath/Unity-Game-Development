using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Burn")]
public class BurnStatusEffect : StatusEffect
{
    public override void Tick(Entity owner)
    {
        owner.TakeDamage(value);
    }
}
