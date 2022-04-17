using System;
using UnityEngine;
using UnityEngine.Events;

namespace Control
{
    public class GameInputManager : MonoBehaviour
    {
        public static GameInputManager Instance { get; private set; }
        
        private PlayerControls.PlayerActions _playerControls;

        public static UnityEvent OnJumpButtonDown = new UnityEvent();
        public static UnityEvent OnJumpButtonUp = new UnityEvent();

        private void Awake()
        {
            if (Instance != null && Instance != this)
                Destroy(this.gameObject);
            else
                Instance = this;

            _playerControls = new PlayerControls().Player;
        }

        private void OnEnable()
        {
            _playerControls.Enable();
        }

        private void OnDisable()
        {
            _playerControls.Disable();
        }

        private void Update()
        {
            CheckJumpInputs();
        }

        public Vector2 GetPlayerMovementRaw()
        {
            return _playerControls.MovementRaw.ReadValue<Vector2>();
        }

        public Vector2 GetPlayerMovement()
        {
            return _playerControls.Movement.ReadValue<Vector2>();
        }

        public Vector2 GetMouseDelta()
        {
            return _playerControls.Look.ReadValue<Vector2>();
        }

        public void CheckJumpInputs()
        {
            if (_playerControls.Jump.WasPressedThisFrame())
                OnJumpButtonDown.Invoke();
            if (_playerControls.Jump.WasReleasedThisFrame())
                OnJumpButtonUp.Invoke();
        }
    }
}