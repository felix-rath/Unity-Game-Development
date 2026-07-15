using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewAbility", menuName = "Abilities/Ability")]
public class ScriptableAbility : ScriptableObject
{
    [Header("Info")]
    public String abilityName;
    public Sprite abilityIcon;
    public float duration = 10f;

    [Header("Prefabs")]
    public GameObject abilityPrefab;

    [Header("Cast")]
    public bool isCast;
    public float castTime;
    
    [Header("Extras")]
    public bool targetAlly;
    public float coolDown;
    public List<StatModifier> stats;
    public List<StatusEffect> statusEffects;

    public float GetStat(StatType statType)
    {
        StatModifier mod = stats.Find(x => x.type == statType);
        if (mod != null)
            return mod.value;
    
        return 0f;
    }
}
