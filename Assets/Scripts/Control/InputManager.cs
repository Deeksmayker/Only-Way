using System;
using UnityEngine;
using UnityEngine.Events;

namespace Control
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager Instance { get; private set; }
        
        private PlayerControls _playerControls;

        public static UnityEvent OnJumpButtonDown = new UnityEvent();

        private void Awake()
        {
            if (Instance != null && Instance != this)
                Destroy(this.gameObject);
            else
                Instance = this;

            _playerControls = new PlayerControls();
        }

        private void OnEnable()
        {
            _playerControls.Enable();
        }

        private void OnDisable()
        {
            _playerControls.Disable();
        }

        public Vector2 GetPlayerMovement()
        {
            return _playerControls.Player.Movement.ReadValue<Vector2>();
        }

        public Vector2 GetMouseDelta()
        {
            return _playerControls.Player.Look.ReadValue<Vector2>();
        }

        public bool PlayerJumped()
        {
            return _playerControls.Player.Jump.triggered;
        }
    }
}