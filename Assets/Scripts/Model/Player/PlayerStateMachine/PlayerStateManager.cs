using System;
using Control;
using Model.Weapons;
using UnityEngine;

namespace Model.Player.PlayerStateMachine
{
    [RequireComponent(typeof(GameInputManager))]
    public class PlayerStateManager : MonoBehaviour
    {
        public Animator animator;
        public Weapon weapon;
        
        private PlayerState _currentState;
        public PlayerFightState FightState = new PlayerFightState();

        [NonSerialized] public GameInputManager PlayerInput;

        private void Start()
        {
            PlayerInput = GetComponent<GameInputManager>();
            
            _currentState = FightState;
            _currentState.EnterState(this);
        }

        private void Update()
        {
            _currentState.UpdateState(this);
        }

        public void SwitchState(PlayerState state)
        {
            _currentState = state;
            state.EnterState(this);
        }
    }
}