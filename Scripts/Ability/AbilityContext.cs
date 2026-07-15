using System;
using System.Diagnostics;
using UnityEngine;

public class AbilityContext
{
    public Entity caster;

    public Entity target;

    public AbilitySlot abilitySlot;

    public System.Type GetTargetType()
    {
        if (abilitySlot == null || abilitySlot.ability == null)
            return null;
    
        if (abilitySlot.ability.targetAlly)
            return caster.GetType();
    
        if (caster is Player)
            return typeof(Enemy);
    
        if (caster is Enemy)
            return typeof(Player);
    
        return null;
    }
}
