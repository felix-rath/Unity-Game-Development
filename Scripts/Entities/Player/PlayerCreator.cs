using UnityEngine;

public class PlayerCreator
{

    // Method to instantiate and load the playerobject
    public GameObject Create(GameObject playerPrefab, PlayerData data)
    {
        GameObject playerInstance = InstantiatePrefab(playerPrefab);
        PlayerSetup(playerInstance, data);
        return playerInstance;
    }

    // -------------- CORE --------------

    private GameObject InstantiatePrefab(GameObject prefab)
    {
        return Object.Instantiate(prefab);
    }

    private void PlayerSetup(GameObject playerInstance, PlayerData data)
    {
        Player player = playerInstance.GetComponent<Player>();
        if (data.baseStats != null)
            player.baseStats.ApplyData(data.baseStats);

    }
}
