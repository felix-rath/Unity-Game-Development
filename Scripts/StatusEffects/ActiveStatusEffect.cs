using UnityEngine;

[System.Serializable]
public class ActiveStatusEffect
{
    StatusEffect _effect;
    int _ticks;

    public ActiveStatusEffect(StatusEffect effect)
    {
        _effect = effect;
        _ticks = effect.ticks;
    }

    public bool Tick(Entity owner)
    {
        if (_ticks <= 0)
            return true;

        _effect.Tick(owner);
        _ticks--;
        return false;
    }
}
