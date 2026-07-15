using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newGameMap", menuName = "GameMaps/GameMap")]
public class GameMap : ScriptableObject
{
    public String name;
    public GameObject mapPrefab;
    public List<Transform> spawnPoints;
}
