using System;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private InputSystem_Actions _inputSystem;
    public float Horizontal;
    public bool Attack;

    private void Awake() { _inputSystem = new InputSystem_Actions(); }
    private void OnEnable() { _inputSystem.Enable(); }
    private void OnDisable() { _inputSystem.Disable(); }
    void Update()
    {
        Attack = _inputSystem.Player.Attack.IsPressed();
        Horizontal = _inputSystem.Player.Move.ReadValue<Vector2>().x;
    }

    
}
