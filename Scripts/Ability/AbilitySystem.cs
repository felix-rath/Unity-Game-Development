using System.Collections;
using UnityEngine;

public class AbilitySystem : MonoBehaviour
{
    public Transform abilityStartPos;

    private PlayerAnimationManager _animation;

    private bool _canAttack = true;

    void Start()
    {
        _animation = GetComponent<PlayerAnimationManager>();
    }

    // ---------------- CORE ----------------

    // Main ability pipeline: validation -> execution -> cooldown trigger
    public void CastAbility(AbilitySlot abilitySlot)
    {
        StartCoroutine(UseAbility(abilitySlot));
    }

    private IEnumerator UseAbility(AbilitySlot abilitySlot)
    {
        if (!_canAttack || !abilitySlot.CanCast())
            yield break;

        yield return StartAbility(abilitySlot);

        // cooldown starts only after successful execution (not on input press)
        abilitySlot.StartCoolDown();
    }

    // Handles full ability execution flow (cast timing, animation, spawn, setup)
    private IEnumerator StartAbility(AbilitySlot abilitySlot)
    {
        ScriptableAbility ability = abilitySlot.ability;

        _canAttack = false;

        // Optional cast phase: locks player and delays execution for gameplay balance
        if (ability.isCast)
        {
            _animation.StartCast();
            yield return new WaitForSeconds(ability.castTime);
            _animation.StopCast();
        }
        else
        {
            _animation.StartAttack();
            yield return new WaitForSeconds(ability.castTime);
        }

        // Build runtime context so the ability controls its own behavior
        AbilityContext context = new AbilityContext
        {
            caster = GetComponent<Entity>(),
            abilitySlot = abilitySlot,
        };

        // Spawns ability prefab aligned with camera direction for aiming consistency
        GameObject abObject = Instantiate(
            ability.abilityPrefab,
            abilityStartPos.position,
            Quaternion.LookRotation(context.caster.GetForward())
        );
        
        Ability ab = abObject.GetComponent<Ability>();
        ab.Init(context);

        _canAttack = true;
    }
}