using System.Collections;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    protected AbilityContext _context;
    public void Init(AbilityContext context)
    {
        _context = context;
        StartAbility();
    }

    private void StartAbility()
    {
        Cast();
        StartCoroutine(StopAbility());
    }

    private IEnumerator StopAbility()
    {
        yield return new WaitForSeconds(_context.abilitySlot.ability.duration);
        Destroy(this.gameObject);
    }

    // -------------------- CORE --------------------

    // Ability pipeline: execution -> con??

    public virtual void Cast()
    {
        
    }

    protected void HandleHit(AbilityContext context)
    {
        if (context.target != null)
        {
            Damage damage = DamageCalculator.calculate(context);
            context.target.TakeDamage(damage);
            context.target.GetComponent<StatusEffectSystem>().AddEffects(context.abilitySlot.ability.statusEffects);
        }
        AbilityEnd();
    }

    protected virtual void AbilityEnd()
    {
        Destroy(this.gameObject);
    }
}
