using UnityEngine;

public interface ITargetStrategy
{
    void Start(Entity entity);
    void Update();
    void Stop();

    TargetData GetTargetData();
    bool IsFinished{get;}
}
