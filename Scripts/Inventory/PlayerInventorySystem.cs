using System.Collections.Generic;
using UnityEngine;

public class PlayerInventorySystem : MonoBehaviour
{
    public AbilitySlot DodgeAbilitySlot;
    public AbilitySlot LeftAbilitySlot;
    public AbilitySlot RightAbilitySlot;
    public AbilitySlot LeftSpecialAbility;
    public AbilitySlot RightSpecialAbility;

    InputManager _input => InputManager.Instance;
    AbilitySystem _abSystem;

    private void Start()
    {
        _abSystem = GetComponent<AbilitySystem>();
        SubscribeEvents();
    }

    private void OnDestroy()
    {
        UnsubscribeEvents();
    }

    void Update()
    {
        UpdateAbilityCoolDown();
    }

    // ---------------- EVENTS ----------------

    void SubscribeEvents()
    {
        _input.OnDodge += OnDodge;
        _input.OnLeftAbility += OnLeftAbility;
        _input.OnRightAbility += OnRightAbility;
        _input.OnLeftSpecialAbility += OnLeftSpecialAbility;
        _input.OnRightSpecialAbility += OnRightSpecialAbility;
    }

    void UnsubscribeEvents()
    {
        _input.OnDodge -= OnDodge;
        _input.OnLeftAbility -= OnLeftAbility;
        _input.OnRightAbility -= OnRightAbility;
        _input.OnLeftSpecialAbility -= OnLeftSpecialAbility;
        _input.OnRightSpecialAbility -= OnRightSpecialAbility;
    }

    // ---------------- EVENT HANDLERS ----------------

    void OnDodge() => _abSystem.CastAbility(DodgeAbilitySlot);
    void OnLeftAbility() => _abSystem.CastAbility(LeftAbilitySlot);
    void OnRightAbility() => _abSystem.CastAbility(RightAbilitySlot);
    void OnLeftSpecialAbility() => _abSystem.CastAbility(LeftSpecialAbility);
    void OnRightSpecialAbility() => _abSystem.CastAbility(RightSpecialAbility);

    // ---------------- CORE ----------------

    void UpdateAbilityCoolDown()
    {
        DodgeAbilitySlot.UpdateCd();
        RightAbilitySlot.UpdateCd();
        LeftAbilitySlot.UpdateCd();
        RightSpecialAbility.UpdateCd();
        LeftSpecialAbility.UpdateCd();
    }
}