using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class AbilityInventory
{
    public AbilitySlot leftAbilitySlot;
    public AbilitySlot rightAbilitySlot;
    public AbilitySlot leftSpecialAbilitySlot;
    public AbilitySlot rightSpecialAbilitySlot;
    public AbilitySlot dodgeAbilitySlot;

    public void UpdateAllCd()
    {
        leftAbilitySlot.UpdateCd();
        rightAbilitySlot.UpdateCd();
        leftSpecialAbilitySlot.UpdateCd();
        rightSpecialAbilitySlot.UpdateCd();
        dodgeAbilitySlot.UpdateCd();
    }

}
