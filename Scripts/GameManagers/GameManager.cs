using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject playerPrefab;

    private PlayerCreator _creator;
    private GameMapLoader _mapLoader;
    private GameObject _player;

    public GameMap map; // DELTE DEBUG


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _creator = new PlayerCreator();
        _mapLoader = new GameMapLoader();
    }

    // DELETE ONLY TEST DEBUG, WHOLE UPDATE
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartGame(map);
        }
    }

    // ------------------- CORE -------------------

    // Lobby
    public void StartLobby()
    {
        StartCoroutine(StartLobbyFlow("ThirdPersonRogueLikeLobbyScene"));
    }

    private IEnumerator StartLobbyFlow(string sceneName)
    {
        yield return SceneLoader.Instance.LoadSceneAsync(sceneName);
        SetupPlayer();
    }

    // InGame
    public void StartGame(GameMap map)
    {
        StartCoroutine(StartGameFlow("ThirdPersonRogueLikeGameScene", map));
    }

    private IEnumerator StartGameFlow(string sceneName, GameMap map)
    {
        yield return SceneLoader.Instance.LoadSceneAsync(sceneName);
        SetupPlayer();
        _mapLoader.Load(map);
    }

    private void SetupPlayer()
    {
        PlayerData data = SaveSystem.Load();
        _player = _creator.Create(playerPrefab, data);

        CameraSystem.Instance.SetTarget(_player.transform);
    }
}
