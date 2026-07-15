using UnityEngine;

[System.Serializable]
public class BaseStats
{

    [Header("Base Stats")]
    public float moveSpeed;
    public float sprintSpeed;
    public float attackDamage;
    public float magicDamage;
    public float maxHealth;
    public float armor;
    public float magicResistence;
    public float critChance;
    public float critMultiplier;

    public void ApplyData(BaseStatsData data)
    {
        this.moveSpeed = data.moveSpeed;
        this.sprintSpeed = data.sprintSpeed;
        this.attackDamage = data.attackDamage;
        this.magicDamage = data.magicDamage;
        this.maxHealth = data.maxHealth;
        this.armor = data.armor;
        this.magicResistence = data.magicResistence;
        this.critChance = data.critChance;
        this.critMultiplier = data.critMultiplier;
    }
}
