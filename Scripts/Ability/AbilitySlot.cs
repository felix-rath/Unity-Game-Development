using UnityEngine;
[System.Serializable]
public class AbilitySlot
{
    public ScriptableAbility ability;

    private float time;

    public void UpdateCd()
    {
        if (!CanCast() && time != 0)
        {
            time -= Time.deltaTime;
        }
    }

    public void StartCoolDown()
    {
        if (ability != null)
            time = ability.coolDown;
    }
    public bool CanCast()
    {
        if (ability == null)
            return false;

        if (time <= 0)
            return true;

        return false;
    }
}
