using UnityEngine;

public abstract class TargetStrategyBase : ITargetStrategy
{
    public bool IsFinished {get; protected set;}

    protected Entity _entity;
    protected TargetData _data;

    public virtual void Start(Entity entity)
    {
        _entity = entity;
        _data = new();
    }
    public virtual void Stop()
    {
        // virtual for later
    }

    public virtual void Update()
    {
        // virtual for later
    }

    // ----------------- CORE -----------------

    public TargetData GetTargetData()
    {
        return _data;
    }
}
