using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Heal")]
public class HealStatusEffect : StatusEffect
{
    public override void Tick(Entity owner)
    {
        owner.Heal(value);
    }
}
