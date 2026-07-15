using UnityEngine;

public class GameMapLoader
{
    private GameObject _currentMap;

    public void Load(GameMap gameMap)
    {
        if (_currentMap == null)
            Object.Destroy(_currentMap);

        _currentMap = Object.Instantiate(gameMap.mapPrefab);
    }
}
