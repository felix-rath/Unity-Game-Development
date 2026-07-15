using UnityEngine;

public class TargetSystem : MonoBehaviour
{
    private ITargetStrategy currentStrategy;

    void Update()
    {
        UpdateStrategy();
    }

    // ------------ CORE ------------

    void UpdateStrategy()
    {
        currentStrategy?.Update();
    }

    public ITargetStrategy SetStrategy(ITargetStrategy newStrategy, Entity entity)
    {
        currentStrategy?.Stop();
        currentStrategy = newStrategy;
        currentStrategy?.Start(entity);
        return currentStrategy;
    }
}
