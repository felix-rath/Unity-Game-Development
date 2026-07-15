using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public event Action OnDodge;
    public event Action OnLeftAbility;
    public event Action OnRightAbility;
    public event Action OnLeftSpecialAbility;
    public event Action OnRightSpecialAbility;

    // UI
    public event Action<bool> OnPause;
    private bool _paused;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetButtonDown("DodgeAbility"))
            OnDodge?.Invoke();

        if (Input.GetButtonDown("LeftAbility"))
            OnLeftAbility?.Invoke();

        if (Input.GetButtonDown("RightAbility"))
            OnRightAbility?.Invoke();

        if (Input.GetButtonDown("LeftSpecialAbility"))
            OnLeftSpecialAbility?.Invoke();

        if (Input.GetButtonDown("RightSpecialAbility"))
            OnRightSpecialAbility?.Invoke();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _paused = !_paused;

            SetCursor(_paused);
            OnPause?.Invoke(_paused);
        }
    }

    private void SetCursor(bool unlocked)
    {
        Cursor.lockState = unlocked ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = unlocked;
    }
}