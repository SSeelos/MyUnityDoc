using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInputManager))]
public class PlayerManager : MonoBehaviour
{
    PlayerInputManager manager;

    public static InputActions InputActions { get; private set; }

    [SerializeField]
    List<PlayerInput> players;

    private void Awake()
    {
        manager = GetComponent<PlayerInputManager>();
        InputActions = new InputActions();


    }
    private void OnEnable()
    {
        manager.onPlayerJoined += Manager_onPlayerJoined;
    }
    private void OnDisable()
    {
        manager.onPlayerJoined -= Manager_onPlayerJoined;
    }

    private void Manager_onPlayerJoined(PlayerInput playerInput)
    {
        players.Add(playerInput.GetComponent<PlayerInput>());
        playerInput.transform.SetParent(manager.transform);
    }
}
