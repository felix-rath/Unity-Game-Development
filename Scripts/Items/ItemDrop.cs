using UnityEngine;

public class ItemDrop : MonoBehaviour, IPickup
{
    public void pickUp()
    {
        
        Destroy(this.gameObject);
    }
}
