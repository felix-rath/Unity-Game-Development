using UnityEngine;

public abstract class StatusEffect : ScriptableObject
{
    public int ticks;
    public float value;
    public abstract void Tick(Entity owner);
}
