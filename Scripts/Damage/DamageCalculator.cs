using UnityEngine;

class DamageCalculator
{
    public static Damage calculate(AbilityContext context)
    {
        // ---------------- BASE (Entity direct) ----------------
        float attackDamage = context.caster.baseStats.attackDamage;
        float magicDamage  = context.caster.baseStats.magicDamage;

        // ---------------- ABILITY SCALING ----------------
        attackDamage += context.abilitySlot.ability.GetStat(StatType.AttackDamage);
        magicDamage  += context.abilitySlot.ability.GetStat(StatType.MagicDamage);

        // ---------------- CRIT (BASE ONLY) ----------------
        float critChance = context.caster.baseStats.critChance;
        float critMultiplier = context.caster.baseStats.critMultiplier;

        bool isCrit = Random.value < (critChance / 100f);

        if (isCrit)
        {
            attackDamage *= critMultiplier;
            magicDamage  *= critMultiplier;
        }

        // ---------------- DEFENSE (BASE ONLY) ----------------
        float armor = context.target.baseStats.armor;
        float magicResist = context.target.baseStats.magicResistence;

        float finalPhysical = attackDamage * (100f / (100f + armor));
        float finalMagic    = magicDamage  * (100f / (100f + magicResist));

        return new Damage
        {
            physical = finalPhysical,
            magic = finalMagic,
            isCrit = isCrit
        };
    }
}