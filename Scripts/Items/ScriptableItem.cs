using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Items/Item")]
public class ScriptableItem : ScriptableObject
{
    public String itemName;
    public Sprite icon;
    public GameObject prefab;
    public RarityType rarity;
    public List<StatModifier> stats;
    public List<StatusEffect> effects;

    [Header("Weapon")]
    public bool isWeapon;
    public ScriptableAbility FirstAbility;
    public ScriptableAbility SecondAbility;
}
