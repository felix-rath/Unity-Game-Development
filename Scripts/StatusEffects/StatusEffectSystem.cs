using System.Collections.Generic;
using UnityEngine;

public class StatusEffectSystem : MonoBehaviour
{
    // Properties
    float tickInterval = 1f; // In seconds

    // private variables
    [SerializeField] List<ActiveStatusEffect> _activeEffects = new();
    Entity _owner;
    float timer;

    void Start()
    {
        _owner = GetComponent<Entity>();
    }

    void Update()
    {
        if (_activeEffects.Count == 0)
            return;

        UpdateTickTimer();
        UpdateTickEffects();
    }

    // -------------- CORE --------------

    public void AddEffects(List<StatusEffect> effects)
    {
        foreach (StatusEffect effect in effects)
        {
        _activeEffects.Add(new ActiveStatusEffect(effect));
        }
    }

    void UpdateTickTimer()
    {
        timer -= Time.deltaTime;
    }

    void UpdateTickEffects()
    {
        if (timer > 0)
            return;
        timer = tickInterval;
        
        for (int i = _activeEffects.Count - 1; i >= 0; i--)
        {
            ActiveStatusEffect active = _activeEffects[i];

            bool finished = active.Tick(_owner);
            if (finished)
                _activeEffects.RemoveAt(i);
        }
    }
}
