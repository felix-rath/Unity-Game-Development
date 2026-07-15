using UnityEngine;

public class DirectionStrategy : TargetStrategyBase
{
    public override void Start(Entity entity)
    {
        base.Start(entity);
        CreateData();
        IsFinished = true;
    }

    void CreateData()
    {
        _data.hasTarget = true;
        _data.target = _entity;
    }
}
