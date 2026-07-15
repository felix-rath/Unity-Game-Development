using UnityEngine;

[System.Serializable]
public class EnemyAnimationSet
{
    [Header("Locomotion")]
    public AnimationClip idle;
    public AnimationClip walk;

    [Header("Actions")]
    public AnimationClip dash;
    public AnimationClip jump;
    public AnimationClip escape;

    [Header("Combat")]
    public AnimationClip meleeAttack;
    public AnimationClip rangedAttack;
    
    [Header("Magic")]
    public AnimationClip castSpell;
}